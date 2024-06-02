using CsvHelper;
using System.Globalization;

namespace WFInterface
{

    public partial class Form1 : Form
    {
        //This is here in case users.csv is lost somewhere else, just let it be
        //As of now, the users.csv should be in bin\debug folder, if it isn't, it won't work
        private string usersPath = "users.csv";
        public Form1()
        {
            InitializeComponent();
        }

        //This piece of code checks for the username and password from database
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (OpenUsers(TxtUsername.Text, TxtPassword.Text, usersPath) == true)
             //if (TxtUsername.Text == "Test" && TxtPassword.Text == "1234")
            {
                new ActualInterface().Show();
                this.Hide();
            }
            else
            {
                //Incorrect password or username textbox
                MessageBox.Show("The username or password are incorrect. Try again");
                TxtUsername.Clear();
                TxtPassword.Clear();
                TxtUsername.Focus();
                TxtUsername.ForeColor = Color.Black;
                if (TxtPassword.Text == "")
                {
                    TxtPassword.Text = "Password";
                    // v This sets the password character back to 'null' from '*' 
                    TxtPassword.PasswordChar = '\0';
                    TxtPassword.ForeColor = Color.Silver;
                }
            }
        }

        //This just exits the application upon clicking "Exit"
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Enters and Leaves are for textbox interactions
        private void TxtUsername_Enter(object sender, EventArgs e)
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

        private void TxtPassword_Enter(object sender, EventArgs e)
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
        
        //Method to open a file with users and try to log in
        //uses CsvHelper to search through a csv to find user data
        public static bool OpenUsers(string username, string password, string filePath)
        {
            try
            {
                if (File.Exists("users.csv"))
                {
                    using (var reader = new StreamReader("users.csv"))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<User>();

                        foreach (var user in records) 
                        { 
                            if (user.Login == username)
                            {
                                if (user.Password == password)
                                {
                                    return true;
                                }
                            }
                        }
                        
                    }
                }
            } 
            catch (Exception ex)
            {
                throw;
            }
            return false;
        }
        public class User
        {
            public string Login { get; set; } = "";
            public string Password { get; set; } = "";
            public string UserName { get; set; } = "";
            public string UserSurname { get; set; } = "";
            public bool IsAdmin { get; set; } = false;
        }
    }
}
