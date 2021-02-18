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
    public partial class editLocation : Form
    {
        public static editLocation keepEditLoaction = null;
        private Location location;
        private string orginalLocationName;
        OpenFileDialog ofd;
        public editLocation(Location location , OpenFileDialog inOfd)
        {
            InitializeComponent();
            keepEditLoaction = this;
            this.location = location;
            orginalLocationName = location.getLocationName();
            ofd = inOfd;
        }

        private void editLocation_Load(object sender, EventArgs e)
        {
            //Load data from Array
            lblOutput.Text = "";
            txtLocationName.Text = location.getLocationName();
            txtStreetNameNum.Text = location.getStreetNumName();
            txtCounty.Text = location.getCounty();
            txtPostCode.Text = location.getPostCode();
            txtLatitude.Text = Convert.ToString(location.getLatitude());
            txtLongitude.Text = Convert.ToString(location.getLongitude());                    
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            try
            {
                //Assign Data to Array
            location.setLocationName(txtLocationName.Text);
            location.setStreetNumName(txtStreetNameNum.Text);
            location.setCounty(txtCounty.Text);
            location.setPostCode(txtPostCode.Text);
            location.setLatitude(Convert.ToDouble(txtLatitude.Text));
            location.setLongitude(Convert.ToDouble(txtLongitude.Text));
            string[] lines = File.ReadAllLines(ofd.FileName);
            using (StreamWriter writer = new StreamWriter(ofd.FileName))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {   //Search for Location name 
                    if (lines[currentLine - 1] == orginalLocationName)
                    {   //Write new location to file
                        writer.WriteLine(location.getLocationName());
                        writer.WriteLine(location.getStreetNumName());
                        writer.WriteLine(location.getCounty());
                        writer.WriteLine(location.getPostCode());
                        writer.WriteLine(location.getLatitude());
                        writer.WriteLine(location.getLongitude());
                        currentLine = currentLine + 6;
                        writer.WriteLine(lines[currentLine - 1]);                    
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
            lblOutput.Text = "Location Editied.";
            }
            catch(Exception err)
            {
                lblOutput.Text = (err.Message + "Enetr Vaild Data.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            keepEditLoaction.Hide();
            Form1.keepForm1.Show();
        }


    }
}
