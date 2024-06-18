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

        //DO NOT DELETE
        public ActualInterface(User user)
        {
            InitializeComponent();
            _currentUser = user;
            DisplayUserInfo();
        }

        //DO NOT DELETE
        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
            MessageBox.Show("Succesfully logged out!");
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

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

        }

        //DO NOT DELETE
        private void DisplayUserInfo()
        {
            lblUsername.Text = _currentUser.UserName;
        }
    }
}
