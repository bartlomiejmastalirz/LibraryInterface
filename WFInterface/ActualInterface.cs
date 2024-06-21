using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInterface
{
    public partial class ActualInterface : Form
    {
        //DO NOT DELETE
        private User _currentUser;
        private MyProfileForm _profileForm; // Store the instance of MyProfileForm

        //DO NOT DELETE
        public ActualInterface(User user)
        {
            InitializeComponent();
            _currentUser = user;
            DisplayUserInfo();
        }

        //DO NOT DELETE
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            if (_profileForm != null)
            {
                _profileForm.FormClosed -= MyProfileForm_FormClosed; // Unsubscribe event handler
                _profileForm.Close();
                _profileForm.Dispose();
            }

            this.Close(); // Close MainForm
            this.Dispose();
            MessageBox.Show("Successfully logged out!");
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "Search for books...")
            {
                TxtSearch.Text = "";
                TxtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                TxtSearch.Text = "Search for books...";
                TxtSearch.ForeColor = Color.Silver;
            }
        }

        //This button appears the My Profile form and hides this current one
        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            if (_profileForm == null || _profileForm.IsDisposed)
            {
                _profileForm = new MyProfileForm(_currentUser, this);
                _profileForm.FormClosed += MyProfileForm_FormClosed; // Subscribe to the FormClosed event
            }
            PositionFormBehind(_profileForm, this); //This sets the position of the other form to this position
            _profileForm.Show();
            this.Hide();
        }

        private void MyProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Shows Actualinterface form again when MyProfileForm is closed
        }

        //DO NOT DELETE
        private void DisplayUserInfo()
        {
            lblUsername.Text = _currentUser.UserName + ' ' + _currentUser.UserSurname;
        }

        //Shows the Admin button to admin user
        private void ActualInterface_Load(object sender, EventArgs e)
        {
            if (_currentUser.IsAdmin)
            {
                btnAdminPanel.Visible = true;
            }
            else
            {
                btnAdminPanel.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PositionFormBehind(Form childForm, Form parentForm)
        {
            // Set the location of the child form to be the same as the parent form
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = parentForm.Location;
        }

    }
}
