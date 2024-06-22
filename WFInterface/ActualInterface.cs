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

namespace WFInterface
{
    public partial class ActualInterface : Form
    {
        //DO NOT DELETE
        private User _currentUser;
        private MyProfileForm _profileForm; // Store the instance of MyProfileForm
        private List<Book> _allBooks;
        private List<Book> _filteredBooks;

        //DO NOT DELETE
        public ActualInterface(User user)
        {
            InitializeComponent();
            _currentUser = user;
            DisplayUserInfo();
            LoadBooks();
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            StyleDataGridView();
        }
        private void LoadBooks()
        {
            using (var reader = new StreamReader("books.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _allBooks = csv.GetRecords<Book>().ToList();
            }

            _allBooks = _allBooks.OrderByDescending(book => int.Parse(book.Year)).ToList(); // Sort books by year
            _filteredBooks = new List<Book>(_allBooks);
            UpdateBookList();
        }

        //DO NOT DELETE
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

        private void UpdateBookList()
        {
            // Create a data table excluding the BookID column
            var dataTable = new DataTable();
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Year");

            foreach (var book in _filteredBooks)
            {
                dataTable.Rows.Add(book.Title, book.Author, book.Year);
            }

            bookListView.DataSource = dataTable;

            // Set the width of the title and author columns
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

            bookListView.AutoResizeColumns();
            bookListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void StyleDataGridView()
        {
            Font font = new Font("Segoe UI", 12);

            bookListView.Font = font;
            bookListView.DefaultCellStyle.Font = font;
            bookListView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            bookListView.BackgroundColor = Color.FromArgb(238, 231, 215);
            bookListView.DefaultCellStyle.BackColor = Color.FromArgb(246, 238, 227);
            bookListView.DefaultCellStyle.ForeColor = Color.Black;
            bookListView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(229, 203, 186);

            bookListView.EnableHeadersVisualStyles = false;
            bookListView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 189, 165);
            bookListView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            bookListView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            bookListView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 222, 207);
            bookListView.DefaultCellStyle.SelectionForeColor = Color.Black;

            bookListView.RowHeadersVisible = false;
            bookListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                _profileForm = new MyProfileForm(_currentUser, this);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PositionFormBehind(Form childForm, Form parentForm)
        {
            // Set the location of the child form to be the same as the parent form
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = parentForm.Location;
        }

    }
    public class User
    {
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public string UserName { get; set; } = "";
        public string UserSurname { get; set; } = "";
        public bool IsAdmin { get; set; } = false;
        public List<int> BooksRented { get; set; } = new List<int>();

        public void ParseBooksRented(string booksRented)
        {
            if (!string.IsNullOrEmpty(booksRented))
            {
                BooksRented = booksRented.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToList();
            }
        }
    }

    public class Book
    {
        public int BookID { get; set; } = 0;
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Year { get; set; } = "";
        public bool Rented { get; set; } = false;
    }
}
