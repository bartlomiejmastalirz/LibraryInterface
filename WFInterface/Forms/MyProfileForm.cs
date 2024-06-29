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

            //this.Size = new Size(877, 600);
        }
        private void DisplayUserInfo()
        {
            lblName.Text = _currentUser.UserName;
            lblSurname.Text = _currentUser.UserSurname;
            lblLogin.Text = _currentUser.Login;

            lblBooks.Text = "Books Rented: " + string.Join(", ", _currentUser.BooksRented);

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



        //applies layout
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.StartPosition = FormStartPosition.CenterParent;
            this.PerformLayout();
        }

      
    }
}

