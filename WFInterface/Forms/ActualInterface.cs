using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;

namespace WFInterface
{
    public partial class ActualInterface : Form
    {
        //DO NOT DELETE
        private User _currentUser;
        private MyProfileForm _profileForm; // Store the instance of MyProfileForm
        private List<Book> _allBooks;
        private List<Book> _filteredBooks;
        private List<Audiobook> _allAudiobooks= new List<Audiobook>();
        private AdminPanel _adminPanel;
        private bool showingBooks = true;

        //DO NOT DELETE
        public ActualInterface(User user)
        {
            InitializeComponent();
            _currentUser = user;
            DisplayUserInfo();

            _allBooks = Book.LoadBooksFromCsv("books.csv");
            _filteredBooks = new List<Book>(_allBooks);

            TxtSearch.TextChanged += TxtSearch_TextChanged;
            btnToggleView.Text = "Show Audiobooks";
            StyleDataGridView();
            UpdateBookList();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            if (_profileForm != null)
            {
                _profileForm.FormClosed -= MyProfileForm_FormClosed; // Unsubscribe event handler
                _profileForm.Close();
                _profileForm.Dispose();
            }

            this.Close(); // Close MainForm
            this.Dispose();
            MessageBox.Show("Successfully logged out!");
        }

        private List<Book> GetRentedBooksForUser(User user)
        {
            List<Book> rentedBooks = new List<Book>();

            foreach (var bookId in user.BooksRented)
            {
                Book rentedBook = _allBooks.FirstOrDefault(b => b.BookID == bookId);
                if (rentedBook != null)
                {
                    rentedBooks.Add(rentedBook);
                }
            }

            return rentedBooks;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = TxtSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchText) || searchText == "search for books...")
            {
                _filteredBooks = new List<Book>(_allBooks); // Reset to all books if search text is empty
            }
            else
            {
                _filteredBooks = _allBooks
                    .Where(book => book.Title.ToLower().Contains(searchText) || book.Author.ToLower().Contains(searchText))
                    .ToList();
            }
            UpdateBookList();
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "Search for books...")
            {
                TxtSearch.Text = "";
                TxtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                TxtSearch.Text = "Search for books...";
                TxtSearch.ForeColor = Color.Silver;
            }
        }

        //This button appears the My Profile form and hides this current one
        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            if (_profileForm == null || _profileForm.IsDisposed)
            {
                var rentedBooks = GetRentedBooksForUser(_currentUser); // Get the rented books
                _profileForm = new MyProfileForm(_currentUser, rentedBooks, this);
                _profileForm.FormClosed += MyProfileForm_FormClosed; // Subscribe to the FormClosed event
            }
            PositionFormBehind(_profileForm, this); //This sets the position of the other form to this position
            _profileForm.Show();
            this.Hide();
        }

        private void MyProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Shows Actualinterface form again when MyProfileForm is closed
        }

        //DO NOT DELETE
        private void DisplayUserInfo()
        {
            lblUsername.Text = _currentUser.UserName + ' ' + _currentUser.UserSurname;
        }

        //Shows the Admin button to admin user
        private void ActualInterface_Load(object sender, EventArgs e)
        {
            if (_currentUser.IsAdmin)
            {
                btnAdminPanel.Visible = true;
            }
            else
            {
                btnAdminPanel.Visible = false;
            }
        }
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            if (_adminPanel == null || _adminPanel.IsDisposed)
            {
                _adminPanel = new AdminPanel(this);
                _adminPanel.FormClosed += AdminPanel_FormClosed; // Subscribe to the FormClosed event
            }
            PositionFormBehind(_adminPanel, this); // This sets the position of the other form to this position
            _adminPanel.Show();
            this.Hide();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adminPanel = null; // Reset the _adminPanel instance to null
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PositionFormBehind(Form childForm, Form parentForm)
        {
            // Set the location of the child form to be the same as the parent form
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = parentForm.Location;
        }

        private void btnToggleView_Click(object sender, EventArgs e)
        {
            // Toggle between showing books and audiobooks
            showingBooks = !showingBooks;

            if (showingBooks)
            {
                // Update DataGridView to display books
                UpdateBookList();
                ((Button)sender).Text = "Show Audiobooks"; // Update button text
            }
            else
            {
                // Update DataGridView to display audiobooks
                UpdateAudiobookList();
                ((Button)sender).Text = "Show Books"; // Update button text
            }
        }

        private void UpdateBookList()
        {
            // Create a DataTable and add columns
            var dataTable = new DataTable();
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Year");

            // Populate the DataTable with book data
            foreach (var book in _filteredBooks)
            {
                dataTable.Rows.Add(book.Title, book.Author, book.Year);
            }

            // Set the DataTable as the DataSource for the DataGridView
            bookListView.DataSource = dataTable;

            // Set columns to read-only and disable resizing
            foreach (DataGridViewColumn column in bookListView.Columns)
            {
                column.ReadOnly = true;
                column.Resizable = DataGridViewTriState.False;
            }

            // Set the width of the title and author columns and wrap text
            if (bookListView.Columns["Title"] != null)
            {
                bookListView.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                bookListView.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            if (bookListView.Columns["Author"] != null)
            {
                bookListView.Columns["Author"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                bookListView.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            if (bookListView.Columns["Year"] != null)
            {
                bookListView.Columns["Year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                bookListView.Columns["Year"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            // Set row height and disable row resizing
            bookListView.RowTemplate.Height = 40;
            bookListView.AllowUserToResizeRows = false;
            bookListView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Resize and fill columns
            bookListView.AutoResizeColumns();
            bookListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disallow sorting on columns
            foreach (DataGridViewColumn column in bookListView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void UpdateAudiobookList()
        {
            // Create a DataTable and add columns
            var dataTable = new DataTable();
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Length (min)"); // Add column for audiobook length


            if (_allAudiobooks.Count == 0)
            {
                // If no audiobooks are available, show a message in the DataGridView
                dataTable.Rows.Add("No content here", "None", "None", "0");
            }
            else
            {
                foreach (var audiobook in _allAudiobooks)
                {
                    dataTable.Rows.Add(audiobook.Title, audiobook.Author, audiobook.Year, audiobook.lenMinutes);
                }
            }

            // Set the DataTable as the DataSource for the DataGridView
            bookListView.DataSource = dataTable;

            // Set columns to read-only and disable resizing
            foreach (DataGridViewColumn column in bookListView.Columns)
            {
                column.ReadOnly = true;
                column.Resizable = DataGridViewTriState.False;
            }

            // Set the width of the title and author columns and wrap text
            if (bookListView.Columns["Title"] != null)
            {
                bookListView.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                bookListView.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            if (bookListView.Columns["Author"] != null)
            {
                bookListView.Columns["Author"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                bookListView.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            if (bookListView.Columns["Year"] != null)
            {
                bookListView.Columns["Year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                bookListView.Columns["Year"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            if (bookListView.Columns["Length (min)"] != null)
            {
                bookListView.Columns["Length (min)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                bookListView.Columns["Length (min)"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            // Set row height and disable row resizing
            bookListView.RowTemplate.Height = 40;
            bookListView.AllowUserToResizeRows = false;
            bookListView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Resize and fill columns
            bookListView.AutoResizeColumns();
            bookListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disallow sorting on columns
            foreach (DataGridViewColumn column in bookListView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void StyleDataGridView()
        {
            // Set font and style for the DataGridView
            Font font = new Font("Segoe UI", 12);

            bookListView.Font = font;
            bookListView.DefaultCellStyle.Font = font;
            bookListView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Set background and foreground colors
            bookListView.BackgroundColor = Color.FromArgb(238, 231, 215);
            bookListView.DefaultCellStyle.BackColor = Color.FromArgb(246, 238, 227);
            bookListView.DefaultCellStyle.ForeColor = Color.Black;
            bookListView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(229, 203, 186);

            // Set header styles
            bookListView.EnableHeadersVisualStyles = false;
            bookListView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 189, 165);
            bookListView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            bookListView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set selection styles
            bookListView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 222, 207);
            bookListView.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Hide row headers and set column auto-size mode
            bookListView.RowHeadersVisible = false;
            bookListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Resize columns after styling
            bookListView.AutoResizeColumns();
            bookListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

