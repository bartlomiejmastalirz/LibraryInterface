using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

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
                        string query = "SELECT * FROM Users WHERE Login = @Login AND Password = @Password";
                        using (var command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Login", login);
                            command.Parameters.AddWithValue("@Password", password);

                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string userName = reader["UserName"].ToString();
                                    string userSurname = reader["UserSurname"].ToString();
                                    bool isAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                                    string booksRented = reader["BooksRented"].ToString();

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

        private void registerLabel_Click(object sender, EventArgs e)
        {
            //Label for registering new users

        }

        //A login function
        //private void PerformLogin()
        //{
        //    string username = TxtUsername.Text;
        //    string password = TxtPassword.Text;

        //    User user = GetUserFromCsv(username);

        //    if (user != null && ValidatePassword(user)) //checks if user exists and input password is correct
        //    {
        //        ActualInterface actualInterface = new ActualInterface(user);
        //        actualInterface.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("The username or password are incorrect. Try again.");
        //    }
        //}

        //With the help of CSVHelper we get all the user data already here and push it to next forms
        //private User GetUserFromCsv(string username)
        //{
        //    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.csv");

        //    using (var reader = new StreamReader(filePath))
        //    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //    {
        //        csv.Read();
        //        csv.ReadHeader();
        //        while (csv.Read())
        //        {
        //            var user = new User         //Makes a new user object with the data parsed from CSV
        //            {
        //                Login = csv.GetField<string>("Login"),
        //                Password = csv.GetField<string>("Password"),
        //                UserName = csv.GetField<string>("UserName"),
        //                UserSurname = csv.GetField<string>("UserSurname"),
        //                IsAdmin = csv.GetField<bool>("IsAdmin"),
        //                BooksRented = csv.GetField<string>("BooksRented")
        //                                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
        //                                .Select(int.Parse)
        //                                .ToList()

        //            };

        //            if (user.Login == username)
        //            {
        //                return user;
        //            }
        //        }
        //    }
        //    return null;                    //A bit dangerous but will do lol
        //}


        //private User AuthenticateUser(string login, string password)
        //{
        //    using (var reader = new StreamReader("users.csv"))
        //    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true }))
        //    {
        //        var records = csv.GetRecords<dynamic>().ToList();
        //        foreach (var record in records)
        //        {
        //            if (record.Login == login && record.Password == password)
        //            {
        //                var user = new User
        //                {
        //                    Login = record.Login,
        //                    Password = record.Password,
        //                    UserName = record.UserName,
        //                    UserSurname = record.UserSurname,
        //                    IsAdmin = bool.Parse(record.IsAdmin)
        //                };
        //                user.ParseBooksRented(record.BooksRented);
        //                return user;
        //            }
        //        }
        //    }

        //    return null;
        //}


        //private bool ValidatePassword(User user)    //certified hackerman password validation, very safe indeed
        //{
        //    string password = TxtPassword.Text;
        //    return user.Password == password;
        //}
    }
}
