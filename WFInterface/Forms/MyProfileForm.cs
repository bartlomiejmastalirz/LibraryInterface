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
        }

        private void DisplayUserInfo()
        {
            lblName.Text = _currentUser.UserName;
            lblSurname.Text = _currentUser.UserSurname;
            lblLogin.Text = _currentUser.Login;
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.StartPosition = FormStartPosition.CenterParent;
            this.PerformLayout();
        }
    }
}
