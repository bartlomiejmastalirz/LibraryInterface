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
    public partial class AdminPanel : Form
    {
        private ActualInterface _actualInterface;
        public AdminPanel(ActualInterface actualInterface)
        {
            InitializeComponent();
            _actualInterface = actualInterface;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            PositionFormBehind(_actualInterface, this);
            this.Hide();
            _actualInterface.Show();
        }

        private void PositionFormBehind(Form childForm, Form parentForm)
        {
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = parentForm.Location;
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string AuthorAdd = tbAuthorAdd.Text;
            string TitleAdd = tbTitleAdd.Text;
            string YearAdd = tbYearAdd.Text;

            if (AuthorAdd != string.Empty && YearAdd != string.Empty && TitleAdd != string.Empty)
            {
                DialogResult result = MessageBox.Show($"Author: {AuthorAdd}\n Year: {YearAdd}\n Title: {TitleAdd}\n",
                "Confirm message", MessageBoxButtons.OKCancel);
                
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Successfully added to your book list!", "", MessageBoxButtons.OK) ; 
                }
            } 
            else
            {
                MessageBox.Show("Provide missing data", "Error Message", MessageBoxButtons.OK);
            }
        }
    }
}