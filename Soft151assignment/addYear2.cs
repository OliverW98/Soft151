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
    public partial class addYear2 : Form
    {
        public static addYear2 keepAddYear2 = null;
        private int year;
        private string yearDescription;
        private int month = 0;
        private Year newYear;

        public addYear2(int year, string yearDescription)
        {
            InitializeComponent();
            this.year = year;
            this.yearDescription = yearDescription;
            this.newYear = new Year(yearDescription, year);
            keepAddYear2 = this;
            lblMonth.Text = "Enter data for month " + (month + 1) + " and save month."; 
        }

        private void btnSaveMonth_Click(object sender, EventArgs e)
        {
            //Assign Values to the Month variable         
            Month input = new Month(month + 1, Convert.ToDouble(txtMaxTemp.Text), Convert.ToDouble(txtMinTemp.Text), Convert.ToDouble(txtNumOfFrostDays.Text), Convert.ToDouble(txtMilsOfRain.Text), Convert.ToDouble(txtHoursOfSun.Text));
            newYear.setMonth(input, month);
            month++;
            //Form Reset
            lblMonth.Text = "Enter data for month " + (month + 1)+" and save month.";           
            txtMaxTemp.Text = "";
            txtMinTemp.Text = "";
            txtNumOfFrostDays.Text = "";
            txtMilsOfRain.Text = "";
            txtHoursOfSun.Text = "";
            //Exits when 12 Months have been entered
            if (month > 11)
            {
                keepAddYear2.Hide();
                Form1.keepForm1.addYear(newYear);
                Form1.keepForm1.Show();             
            }

        }
    }
}
