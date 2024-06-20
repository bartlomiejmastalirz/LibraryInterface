using CsvHelper;
using System.Globalization;

namespace WFInterface
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This piece of code checks for the username and password from database
        internal void LoginButton_Click(object sender, EventArgs e)
        {
            PerformLogin();
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

        //A login function
        private void PerformLogin()
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;

            User user = GetUserFromCsv(username);

            if (user != null && ValidatePassword(user)) //checks if user exists and input password is correct
            {
                ActualInterface actualInterface = new ActualInterface(user);
                actualInterface.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password are incorrect. Try again.");
            }
        }

        //With the help of CSVHelper we get all the user data already here and push it to next forms
        private User GetUserFromCsv(string username)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.csv");

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var user = new User         //Makes a new user object with the data parsed from CSV
                    {
                        Login = csv.GetField<string>("Login"),
                        Password = csv.GetField<string>("Password"),
                        UserName = csv.GetField<string>("UserName"),
                        UserSurname = csv.GetField<string>("UserSurname"),
                        IsAdmin = csv.GetField<bool>("IsAdmin"),
                        BooksRented = csv.GetField<string>("BooksRented")
                                        .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList()
                    };

                    if (user.Login == username)
                    {
                        return user;
                    }
                }
            }
            return null;                    //A bit dangerous but will do lol
        }

        private bool ValidatePassword(User user)    //certified hackerman password validation, very safe indeed
        {
            string password = TxtPassword.Text;
            return user.Password == password;
        }
    }
}
