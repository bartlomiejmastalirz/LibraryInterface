namespace WFInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {   
            //This piece of code checks for the username and password from database
            //TODO: Implement the csv OR database usage to this thing
            if (txtUsername.Text == "Test" && txtPassword.Text == "1234")
            {
                new ActualInterface().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password are incorrect. Try again");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            //This just exits the application upon clicking "Exit"
            Application.Exit();
        }
    }
}
