using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS221_PA6_New
{
    //opening part where the user inputs the CWID
    public partial class frmCWID : Form
    {
        public frmCWID()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       private void BtnOK_Click(object sender, EventArgs e)
       {
            this.Hide();
            frmMain myForm = new frmMain(txtCWID.Text);
            if (myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }
       }

    }
}
