using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInterface.Forms
{
    public partial class RegisterFormcs : Form
    {

        public RegisterFormcs()
        {
            InitializeComponent();
        }

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

        public void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            // !Warning - If anyone uses a password of "Password" it is going to erase it. Too bad!
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.PasswordChar = '*';
                txtConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Confirm Password";
                // v This sets the password character back to 'null' from '*' 
                txtConfirmPassword.PasswordChar = '\0';
                txtConfirmPassword.ForeColor = Color.Silver;
            }
        }

        public void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Your Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Your Name";
                txtName.ForeColor = Color.Silver;
            }
        }

        public void txtSurname_Enter(object sender, EventArgs e)
        {

            if (txtSurname.Text == "Your Surname")
            {
                txtSurname.Text = "";
                txtSurname.ForeColor = Color.Black;
            }
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (txtSurname.Text == "")
            {
                txtSurname.Text = "Your Surname";
                txtSurname.ForeColor = Color.Silver;
            }
        }


        private void PositionFormBehind(Form childForm, Form parentForm)
        {
            // Set the location of the child form to be the same as the parent form
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = parentForm.Location;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Form1 form1 = new Form1();
            PositionFormBehind(form1, this);
            form1.Show();
        }

        private void RegisterFormcs_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = TxtUsername.Text;
            string password = TxtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string userName = txtName.Text;
            string userSurname = txtSurname.Text;
            //bool isAdmin = chkIsAdmin.Checked;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                AddUser.AddUserToDatabase(login, password, userName, userSurname);
                MessageBox.Show("User registered successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
