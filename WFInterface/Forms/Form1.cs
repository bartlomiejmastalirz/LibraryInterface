using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFInterface.Forms;
using System.Security.Cryptography;

namespace WFInterface
{

    public partial class Form1 : Form
    {
        private static readonly string dbPath = "Library.db";

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

                try
                {
                    using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Users WHERE Login = @Login";
                        using (var command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Login", login);
                            //command.Parameters.AddWithValue("@Password", password);

                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string storedHash = reader["Password"].ToString();
                                    string userName = reader["UserName"].ToString();
                                    string userSurname = reader["UserSurname"].ToString();
                                    bool isAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                                    string booksRented = reader["BooksRented"].ToString();

                                    string inputHash = HashPassword(password);

                                    if (storedHash == inputHash)
                                    {
                                        User user = new User
                                        {
                                            Login = login,
                                            Password = password,
                                            UserName = userName,
                                            UserSurname = userSurname,
                                            IsAdmin = isAdmin,
                                            BooksRented = booksRented.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()

                                        };

                                        ActualInterface actualInterface = new ActualInterface(user);
                                        actualInterface.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid login or password.");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Invalid login or password.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during login: {ex.Message}");
                    Debug.WriteLine($"Exception during login: {ex.Message}");
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
        private void PositionFormBehind(Form childForm, Form parentForm)
        {
            // Set the location of the child form to be the same as the parent form
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = parentForm.Location;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            //Label for registering new users
            this.Hide();
            RegisterFormcs registerFormcs = new RegisterFormcs();
            PositionFormBehind(registerFormcs, this);
            registerFormcs.Show();
        }


        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
