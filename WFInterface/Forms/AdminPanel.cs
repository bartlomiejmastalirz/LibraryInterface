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
    }
}