using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Soft151assignment
{
    public partial class addYear : Form
    {

        public static addYear keepAddYear = null;
        public addYear()
        {
            InitializeComponent();
            keepAddYear = this;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            keepAddYear.Hide();
            Form1.keepForm1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
            addYear2 tempAddYear2 = new addYear2(Convert.ToInt32(txtYear.Text), txtYearDescription.Text);          
            tempAddYear2.Show();
            keepAddYear.Hide();
            }catch(Exception)
            {
                lblOutput.Text = "Please enter vaild data";
            }
            //Pass values for Year to new form

        }
    }
}
