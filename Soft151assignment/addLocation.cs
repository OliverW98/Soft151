using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft151assignment
{
    public partial class addLocation : Form
    {
        public static addLocation keepAddLocation = null;
        private Location newLocation;
        private int locationNum;

        public addLocation(int inLocationNum)
        {
            InitializeComponent();
            keepAddLocation = this;
            locationNum = inLocationNum;
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            //Assign Values to the Location variable
              try
               {
                this.newLocation = new Location(locationNum, txtLocationName.Text, txtStreetNameNum.Text, txtCounty.Text, txtPostCode.Text, Convert.ToDouble(txtLatitude.Text), Convert.ToDouble(txtLongitude.Text),0);
                keepAddLocation.Hide();
                Form1.keepForm1.addLocation(newLocation);
                Form1.keepForm1.Show();
           }
            catch (Exception err)
            {
              lblOutput.Text =  err.Message + " Please Enter a valid Data into the fields.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            keepAddLocation.Hide();
            Form1.keepForm1.Show();
        }
    }
}
