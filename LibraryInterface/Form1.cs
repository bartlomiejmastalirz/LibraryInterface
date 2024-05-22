using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryInterfaceWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent; 
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void LoginText_Enter(object sender, EventArgs e)
        {
            if (LoginText.Text == "Login")
            {
                LoginText.Text = "";
                LoginText.ForeColor = Color.Black;
            }
        }

        private void LoginText_Leave(object sender, EventArgs e)
        {
            if (LoginText.Text == "")
            {
                LoginText.Text = "Login";
                LoginText.ForeColor = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.Text = "Password";
                PasswordText.ForeColor = Color.Silver;
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
