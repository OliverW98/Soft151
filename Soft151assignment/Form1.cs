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
    public partial class Form1 : Form
    {
        // to do :
        // check all file paths.  ofd.filename
        // anaylsis graph.
        public static Form1 keepForm1 = null;  
        private Location[] locations;
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            keepForm1 = this;          
            readDataIn();          
        }

        private void readDataIn()
        {           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
            StreamReader inData = new StreamReader(ofd.FileName);
            int numOfLocations;
            int numOfYears;
            numOfLocations = Convert.ToInt32(inData.ReadLine());
            locations = new Location[numOfLocations];
            for (int i = 0; i < numOfLocations; i++)
            {       // Read in Location
                    locations[i] = new Location(i+1,inData.ReadLine(), inData.ReadLine(), inData.ReadLine(), inData.ReadLine(), Convert.ToDouble(inData.ReadLine()), Convert.ToDouble(inData.ReadLine()), numOfYears = Convert.ToInt32(inData.ReadLine()));                   
                    for (int j = 0; j < numOfYears; j++)
                    {   //Read in Year
                        Year inputYear = new Year(inData.ReadLine(), Convert.ToInt32(inData.ReadLine()));
                        locations[i].setYear(inputYear, j);                       
                        for (int k = 0; k < 12; k++)
                        {   //Read in Month                        
                            Month inputMonth = new Month(Convert.ToInt32(inData.ReadLine()), Convert.ToDouble(inData.ReadLine()), Convert.ToDouble(inData.ReadLine()), Convert.ToDouble(inData.ReadLine()), Convert.ToDouble(inData.ReadLine()), Convert.ToDouble(inData.ReadLine()));
                            locations[i].getYear(j).setMonth(inputMonth, k);
                         if (k != 11)
                            {
                              inData.ReadLine();
                            }
                        }
                    }               
            }
            inData.Close();
            populateLocationCB(numOfLocations);
            }
        }

        private void populateLocationCB(int Num)
        {
            cbSelectLocation.Items.Clear();
            //Fill combobox with Location names
            for (int i = 0; i < Num; i++)
            {
               cbSelectLocation.Items.Add(new KeyValuePair<string ,int>(locations[i].getLocationName(),i));            
            }               
        }

        public void addYear(Year year)
        {
            KeyValuePair<string, int> cbSL = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
            Array.Resize(ref locations[cbSL.Value].years, locations[cbSL.Value].years.Length + 1);
            int X = locations[cbSL.Value].getNumOfYears();
            locations[cbSL.Value].setNumOfYears(X + 1);
            locations[cbSL.Value].years[X] = year;
            updateCBs();
            //Read in and store file in an array
            string[] lines = File.ReadAllLines(ofd.FileName);
            using (StreamWriter writer = new StreamWriter(ofd.FileName))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {   //Find Location name                  
                    if (lines[currentLine - 1] == locations[cbSL.Value].getLocationName())
                    {   //Fine End of Years in location                  
                        int addYearPointer = Convert.ToInt32(lines[currentLine + 5]) * 85;
                        //update years in location
                        lines[currentLine + 5] = Convert.ToString(Convert.ToInt32(lines[currentLine + 5]) + 1);
                        for (int i = 0; i < addYearPointer + 7; i++)
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                            currentLine++;
                        }
                        //Add Year and Descripton  to file
                        writer.WriteLine(locations[cbSL.Value].getYear(X).getYearDescription());
                        //Add Months for the Year to file
                        for (int i = 0; i < 12; i++)
                        {
                            writer.WriteLine(locations[cbSL.Value].getYear(X).getYear());
                            writer.WriteLine(i + 1);
                            writer.WriteLine(locations[cbSL.Value].getYear(X).getMonth(i).getMaximumTemp());
                            writer.WriteLine(locations[cbSL.Value].getYear(X).getMonth(i).getMinimumTemp());
                            writer.WriteLine(locations[cbSL.Value].getYear(X).getMonth(i).getNumberOfDaysOfAirFrost());
                            writer.WriteLine(locations[cbSL.Value].getYear(X).getMonth(i).getHoursOfSunShine());
                            writer.WriteLine(locations[cbSL.Value].getYear(X).getMonth(i).getMilsOfRainFall());
                        }
                        //for adding to the end of the file
                        if (lines.Length > currentLine)
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                        }
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
        }

        public void addLocation(Location location)
        {
            Array.Resize(ref locations, locations.Length + 1);
            locations[locations.Length - 1] = location;
            populateLocationCB(locations.Length);
            //Read in and store file in an array
            string[] lines = File.ReadAllLines(ofd.FileName);
            //Change number of location
            lines[0] = Convert.ToString(Convert.ToInt32(lines[0]) + 1);
            using (StreamWriter writer = new StreamWriter(ofd.FileName))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {   //Writeout Array
                    writer.WriteLine(lines[currentLine - 1]);
                }
            }
                //Add location to file
            StreamWriter outData = File.AppendText(ofd.FileName);
            outData.WriteLine(location.getLocationName());
            outData.WriteLine(location.getStreetNumName());
            outData.WriteLine(location.getCounty());
            outData.WriteLine(location.getPostCode());
            outData.WriteLine(location.getLatitude());
            outData.WriteLine(location.getLongitude());
            outData.WriteLine(location.getNumOfYears());
            outData.Close();
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {       
            addYear tempAddYear = new addYear();
            tempAddYear.Show();
            keepForm1.Hide();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            addLocation tempAddLocation = new addLocation(locations.Length);
            tempAddLocation.Show();
            keepForm1.Hide();
        }

        private void btnDisplayYear_Click(object sender, EventArgs e)
        {
            try
            {
                //Find values in comboboxes
                KeyValuePair<string, int> cbSL = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
                KeyValuePair<string, int> cbSY = (KeyValuePair<string, int>)cbSelectYear.SelectedItem;
                Year selectedYear = locations[cbSL.Value].getYear(cbSY.Value);  
                lstOutput.Items.Clear();
                //Display Year
                lstOutput.Items.Add(cbSL.Key);
                lstOutput.Items.Add(selectedYear.getYear()+": "+ selectedYear.getYearDescription());
                //Display Months 
            for (int j = 0; j < selectedYear.numberMonths(); j++)
            {   
                lstOutput.Items.Add(selectedYear.getMonth(j).ToString());
            }
            }
            catch(Exception err)
            {
                lstOutput.Items.Clear();
                lstOutput.Items.Add(err.Message +" Please Enter a valid Location and Year.");
            }            
        }

        private void btnDisplayMonth_Click(object sender, EventArgs e)
        {
            try
            {   //Find values in comboboxes
                KeyValuePair<string, int> cbSL = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
                KeyValuePair<string, int> cbSY = (KeyValuePair<string, int>)cbSelectYear.SelectedItem;              
                Year selectedYear = locations[cbSL.Value].getYear(cbSY.Value);
                lstOutput.Items.Clear();
                //Display Month
                lstOutput.Items.Add(cbSL.Key);
                lstOutput.Items.Add(selectedYear.getYear());
                lstOutput.Items.Add(selectedYear.getMonth(Convert.ToInt32(cbSelectMonth.Text)-1));
            }
            catch (Exception err)
            {
                lstOutput.Items.Clear();
                lstOutput.Items.Add(err.Message + " Please Enter a valid Location, Year and Month.");
            }
        }

        private void btnDisplayLocation_Click(object sender, EventArgs e)
        {
            try
            {   //Find values in combobox
                KeyValuePair<string, int> cbSL = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
                Location selectedLocation = locations[cbSL.Value];
                lstOutput.Items.Clear();
                //Display Location
                lstOutput.Items.Add(selectedLocation.getLocationName());
                lstOutput.Items.Add(selectedLocation.getStreetNumName());
                lstOutput.Items.Add(selectedLocation.getCounty());
                lstOutput.Items.Add(selectedLocation.getPostCode());
                lstOutput.Items.Add("Latitude : " + selectedLocation.getLatitude());
                lstOutput.Items.Add("Longitude : " + selectedLocation.getLongitude());
            }
            catch (Exception err)
            {
                lstOutput.Items.Clear();
                lstOutput.Items.Add(err.Message + " Please Enter a valid Location.");
            }
        }

        private void btnEditMonth_Click(object sender, EventArgs e)
        {
            //Find values in comboboxes
            KeyValuePair<string, int> cbSL = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
            KeyValuePair<string, int> cbSY = (KeyValuePair<string, int>)cbSelectYear.SelectedItem;                 
            editMonth tempEditMonth = new editMonth(locations[cbSL.Value],cbSY.Value,Convert.ToInt32(cbSelectMonth.Text),ofd);
            tempEditMonth.Show();
            keepForm1.Hide();
        }

        private void btnEditYear_Click(object sender, EventArgs e)
        {
            //Find values in comboboxes
            KeyValuePair<string, int> cbSL = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
            KeyValuePair<string, int> cbSY = (KeyValuePair<string, int>)cbSelectYear.SelectedItem;
            editYear tempEditYear = new editYear(cbSY.Value, locations[cbSL.Value],ofd);
            tempEditYear.Show();
            keepForm1.Hide();
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            //Find values in combobox
            KeyValuePair<string, int> cbSL = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
            editLocation tempEditLocation = new editLocation(locations[cbSL.Value], ofd);
            tempEditLocation.Show();
            keepForm1.Hide();
        }

        private void btnAnalysisYear_Click(object sender, EventArgs e)
        {
            //Find values in comboboxes
            KeyValuePair<string, int> cbSL = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
            KeyValuePair<string, int> cbSY = (KeyValuePair<string, int>)cbSelectYear.SelectedItem;
            analysis tempAnalysis = new analysis(cbSY.Value, locations[cbSL.Value]);
            tempAnalysis.Show();
            keepForm1.Hide();
        }

        private void cbSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectYear.Text != "")
            {
                btnEditYear.Enabled = true;
                btnAnalysisYear.Enabled = true;
            }
        }

        private void cbSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectMonth.Text != "")
            {
                btnEditMonth.Enabled = true;
            }
        }

        private void cbSelectLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disable all buttons Month and edit Year button 
            btnEditLocation.Enabled = true; 
            btnEditYear.Enabled = false;
            btnEditMonth.Enabled = false;
            btnAddYear.Enabled = true;
            btnAnalysisYear.Enabled = false;
            updateCBs();
        }

        private void updateCBs()
        {        
            cbSelectYear.Items.Clear();
            cbSelectYear.Text = "";
            cbSelectMonth.Items.Clear();
            cbSelectMonth.Text = "";
            KeyValuePair<string, int> seletedLocation = (KeyValuePair<string, int>)cbSelectLocation.SelectedItem;
            //Update values in Year and Month comboboxes
            for (int i = 0; i < locations[seletedLocation.Value].getNumOfYears(); i++)
            {
                cbSelectYear.Items.Add(new KeyValuePair<string, int>(Convert.ToString(locations[seletedLocation.Value].getYear(i).getYear()), i));              
            }
            for (int j = 0; j < 12; j++)
            {
                cbSelectMonth.Items.Add(j+1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
