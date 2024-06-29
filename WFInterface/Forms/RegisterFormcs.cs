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

        //private void ExitLabel_Click(object sender, EventArgs e)
        //{
        //    //this.Close();
        //    //this.Dispose();

        //    Form1 form1 = new Form1();
        //    PositionFormBehind(form1, this);
        //    form1.Show();

        //}



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


    }
}
