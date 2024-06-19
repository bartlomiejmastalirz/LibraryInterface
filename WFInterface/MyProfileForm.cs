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
        public MyProfileForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            DisplayUserInfo();
        }
        private void DisplayUserInfo()
        {
            lblUserName.Text = _currentUser.UserName;
        }
    }
}

