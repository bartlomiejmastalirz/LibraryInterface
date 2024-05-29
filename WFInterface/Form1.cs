namespace WFInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This piece of code checks for the username and password from database
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //TODO: Implement the csv OR database usage to this thing
            if (TxtUsername.Text == "Test" && TxtPassword.Text == "1234")
            {
                new ActualInterface().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password are incorrect. Try again");
                TxtUsername.Clear();
                TxtPassword.Clear();
                TxtUsername.Focus();
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
    }
}
