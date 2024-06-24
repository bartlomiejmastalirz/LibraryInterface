using CsvHelper;
using CsvHelper.Configuration;
using Dapper;
using System.Data.SQLite;
using System.Globalization;

namespace WFInterface
{

    public partial class Form1 : Form
    {
        private string _dbPath = "Library.db";

        public Form1()
        {
            InitializeComponent();
        }

        //This piece of code checks for the username and password from database
        internal void LoginButton_Click(object sender, EventArgs e)
        {

            {
                string login = TxtUsername.Text;
                string password = TxtPassword.Text;

                User loggedInUser = AuthenticateUser(login, password);

                if (loggedInUser != null)
                {
                    ActualInterface actualInterface = new ActualInterface(loggedInUser);
                    actualInterface.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login or password.");
                }
            }


            //PerformLogin();
        }

        //This just exits the application upon clicking "Exit"
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Enters and Leaves are for textbox interactions
        public void TxtUsername_Enter(object sender, EventArgs e)
        {
            // !Warning - If anyone uses a login of "Login" it is going to erase it. Too bad!
            if (TxtUsername.Text == "Login")
            {
                TxtUsername.Text = "";
                TxtUsername.ForeColor = Color.Black;
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
            {
                TxtUsername.Text = "Login";
                TxtUsername.ForeColor = Color.Silver;
            }
        }

        public void TxtPassword_Enter(object sender, EventArgs e)
        {
            // !Warning - If anyone uses a password of "Password" it is going to erase it. Too bad!
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.Text = "";
                TxtPassword.PasswordChar = '*';
                TxtPassword.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password";
                // v This sets the password character back to 'null' from '*' 
                TxtPassword.PasswordChar = '\0';
                TxtPassword.ForeColor = Color.Silver;
            }
        }




        private User AuthenticateUser(string login, string password)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE Login = @Login AND Password = @Password";
                var user = connection.Query<User>(query, new { Login = login, Password = password }).FirstOrDefault();

                if (user != null)
                {
                    // Parsing BooksRented into a list
                    user.BooksRented = !string.IsNullOrEmpty(user.BooksRentedString)
                                        ? user.BooksRentedString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()
                                        : new List<int>();
                }

                return user;
            }
        }
    }
}
