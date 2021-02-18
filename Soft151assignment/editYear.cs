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
    public partial class editYear : Form
    {       
        public static editYear keepEditYear = null;
        private int yearId;
        private Location location;
        private string orginalYearDescription;
        OpenFileDialog ofd;

        public editYear(int inYearId , Location location , OpenFileDialog inOfd)
        {
            yearId = inYearId;
            this.location = location;
            InitializeComponent();
            keepEditYear = this;
            ofd = inOfd;
        }

        private void editYear_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            //Assign Data to Array
            txtYearDescription.Text = location.getYear(yearId).getYearDescription();
            orginalYearDescription = txtYearDescription.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                location.getYear(yearId).setYearDescription(txtYearDescription.Text);
                string[] lines = File.ReadAllLines(ofd.FileName);
                using (StreamWriter writer = new StreamWriter(ofd.FileName))
                {
                    for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                    {   //Search location
                        if (lines[currentLine - 1] == location.getLocationName())
                        {   //Skip Years in location to Search year description
                            int editYearPointer = Convert.ToInt32(lines[currentLine + 5]) * 85;
                            for (int i = 0; i < editYearPointer; i++)
                            {   //Search Description
                                if (lines[currentLine - 1] == orginalYearDescription)
                                {   //Write to file
                                    writer.WriteLine(location.getYear(yearId).getYearDescription());
                                    currentLine++;
                                }
                                else
                                {
                                    writer.WriteLine(lines[currentLine - 1]);
                                    if(i + 1 < editYearPointer)
                                    {
                                        currentLine++;
                                    }                                   
                                }
                            }
                        }
                        else
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                        }
                    }
                }
                lblEditMonth.Text = "Year Description Edited.";
            }
            catch (Exception err)
            {
                lblOutput.Text = (err.Message);
            }           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            keepEditYear.Hide();
            Form1.keepForm1.Show();
        }
    }
}
