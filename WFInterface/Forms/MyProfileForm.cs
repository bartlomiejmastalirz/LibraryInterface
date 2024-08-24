using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WFInterface
{
    public partial class MyProfileForm : Form
    {
        private User _currentUser;
        private List<Book> _rentedBooks;
        private ActualInterface _parentForm;

        public MyProfileForm(User user, List<Book> rentedBooks, ActualInterface parentForm)
        {
            InitializeComponent();
            _currentUser = user;
            _rentedBooks = rentedBooks;
            _parentForm = parentForm;
            DisplayUserInfo();
            DisplayRentedBooks();
            ApplyDataGridViewStyle(); // Change method name
        }

        private void DisplayUserInfo()
        {
            lblName.Text = "Name: " + _currentUser.UserName;
            lblSurname.Text = "Surname: " + _currentUser.UserSurname;
            lblLogin.Text = "Login: " + _currentUser.Login;
        }

        private void DisplayRentedBooks()
        {
            rentedBooksGridView.DataSource = _rentedBooks.Select(b => new
            {
                b.Title,
                b.Author,
                b.Year
            }).ToList();

            foreach (DataGridViewColumn column in rentedBooksGridView.Columns)
            {
                column.ReadOnly = true;
                column.Resizable = DataGridViewTriState.False;
            }

            if (rentedBooksGridView.Columns["Title"] != null)
            {
                rentedBooksGridView.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                rentedBooksGridView.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            if (rentedBooksGridView.Columns["Author"] != null)
            {
                rentedBooksGridView.Columns["Author"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                rentedBooksGridView.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            if (rentedBooksGridView.Columns["Year"] != null)
            {
                rentedBooksGridView.Columns["Year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                rentedBooksGridView.Columns["Year"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            rentedBooksGridView.RowTemplate.Height = 40;
            rentedBooksGridView.AllowUserToResizeRows = false;
            rentedBooksGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            rentedBooksGridView.AutoResizeColumns();
            rentedBooksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in rentedBooksGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            PositionFormBehind(_parentForm, this);
            this.Hide();
            _parentForm.Show();
        }

        private void PositionFormBehind(Form childForm, Form parentForm)
        {
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = parentForm.Location;
        }

        private void ApplyDataGridViewStyle()
        {
            Font font = new Font("Segoe UI", 12);

            rentedBooksGridView.Font = font;
            rentedBooksGridView.DefaultCellStyle.Font = font;
            rentedBooksGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            rentedBooksGridView.BackgroundColor = Color.FromArgb(238, 231, 215);
            rentedBooksGridView.DefaultCellStyle.BackColor = Color.FromArgb(246, 238, 227);
            rentedBooksGridView.DefaultCellStyle.ForeColor = Color.Black;
            rentedBooksGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(229, 203, 186);

            rentedBooksGridView.EnableHeadersVisualStyles = false;
            rentedBooksGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 189, 165);
            rentedBooksGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            rentedBooksGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            rentedBooksGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 222, 207);
            rentedBooksGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            rentedBooksGridView.RowHeadersVisible = false;
            rentedBooksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            rentedBooksGridView.AutoResizeColumns();
            rentedBooksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
