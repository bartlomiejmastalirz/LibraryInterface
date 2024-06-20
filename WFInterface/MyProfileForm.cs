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
    public partial class MyProfileForm : Form
    {
        private User _currentUser;
        private ActualInterface _actualInterface; //stores AI data

        public MyProfileForm(User user, ActualInterface actualInterface)
        {
            InitializeComponent();
            _currentUser = user;
            _actualInterface = actualInterface;
            DisplayUserInfo();
        }
        private void DisplayUserInfo()
        {
            lblUserName.Text = _currentUser.UserName;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            PositionFormBehind(_actualInterface, this);
            this.Hide();
            _actualInterface.Show();
        }

        private void PositionFormBehind(Form childForm, Form parentForm)
        {
            // Set the location of the child form to be the same as the parent form
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = parentForm.Location;
        }

    }
}

