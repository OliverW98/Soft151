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
    public partial class editMonth : Form
    {
        public static editMonth keepEditMonth = null;
        private Location location;
        private int yearId;
        private int monthId;
        Month month;
        OpenFileDialog ofd;

        public editMonth(Location location ,int inYearId ,int inMonthId, OpenFileDialog inOfd)
        {
            InitializeComponent();
            this.location  = location;
            yearId = inYearId;
            monthId = inMonthId;
            month = location.getYear(yearId).getMonth(monthId - 1);
            keepEditMonth = this;
            ofd = inOfd;
        }

        private void editMonth_Load(object sender, EventArgs e)
        {
            //Load data from Array
            lblOutput.Text = "";
            txtMaxTemp.Text = Convert.ToString(month.getMaximumTemp());
            txtMinTemp.Text = Convert.ToString(month.getMinimumTemp());
            txtNumOfFrostDay.Text = Convert.ToString(month.getNumberOfDaysOfAirFrost());
            txtMilsOfRain.Text = Convert.ToString(month.getMilsOfRainFall());
            txtHoursOfSun.Text = Convert.ToString(month.getHoursOfSunShine());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblEditMonth.Text = "";
            //Assign Data to Array
            month.setMaximumTemp(Convert.ToDouble(txtMaxTemp.Text));
            month.setMinimumTemp(Convert.ToDouble(txtMinTemp.Text));
            month.setNumberOfDaysOfAirFrost(Convert.ToDouble(txtNumOfFrostDay.Text));
            month.setMilsOfRainFall(Convert.ToDouble(txtMilsOfRain.Text));
            month.setHoursOfSunShine(Convert.ToDouble(txtHoursOfSun.Text));
            // try
            // {
            string[] lines = File.ReadAllLines(ofd.FileName);
            using (StreamWriter writer = new StreamWriter(ofd.FileName))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {   //Search location name 
                    if (lines[currentLine - 1] == location.getLocationName())
                    {   //skip through Years in location to find year
                        int editMonthPointer = Convert.ToInt32(lines[currentLine + 5]) * 85;
                        for (int i = 0; i < editMonthPointer; i++)
                        {   //find year
                            if (lines[currentLine - 1] == Convert.ToString(location.getYear(yearId).getYear()))
                            {   //Find Month 
                                for (int j = 0; j < 84; j++)
                                {
                                    if (lines[currentLine - 1] == Convert.ToString(monthId) & lines[currentLine - 2] == Convert.ToString(location.getYear(yearId).getYear()))
                                    {   //write month
                                        writer.WriteLine(monthId);
                                        writer.WriteLine(month.getMaximumTemp());
                                        writer.WriteLine(month.getMinimumTemp());
                                        writer.WriteLine(month.getNumberOfDaysOfAirFrost());
                                        writer.WriteLine(month.getMilsOfRainFall());
                                        writer.WriteLine(month.getHoursOfSunShine());
                                        currentLine = currentLine + 6;                                     
                                    }
                                    else
                                    {
                                        writer.WriteLine(lines[currentLine - 1]);
                                        currentLine++;
                                    }
                                }
                            }
                            else
                            {
                                writer.WriteLine(lines[currentLine - 1]);
                                if (i + 1 < editMonthPointer)
                                {
                                    currentLine++;
                                }                                                           
                            }
                        }
                    }
                    else // trouble area
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
            lblEditMonth.Text = "Month Edited.";
            //  }
            // catch (Exception err)
            // {
            //   lblOutput.Text = (err.Message);
            // }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            keepEditMonth.Hide();
            Form1.keepForm1.Show();
        }


    }
}
