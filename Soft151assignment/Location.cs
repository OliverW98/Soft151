using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft151assignment
{
    public class Location
    {
        private int locationNum;
        private string locationName;
        private string streetNumName;
        private string county;
        private string postCode;
        private double latitude;
        private double longitude;
        private int numOfYears;
        public Year[] years;

        //constructor
        public Location(int inLocationNum,string inLocationName, string inStreetNumName, string inCounty, string inPostCode, double inLatitude, double inLongitude, int inNumOfYears)
        {
            locationNum = inLocationNum;
            locationName = inLocationName;
            streetNumName = inStreetNumName;
            county = inCounty;
            postCode = inPostCode;
            latitude = inLatitude;
            longitude = inLongitude;
            numOfYears = inNumOfYears;
            years = new Year[inNumOfYears];
        }

        //setters
        public void setLocationNum(int inLocationNum)
        {
            locationNum = inLocationNum;
        }
        public void setLocationName(string inLocationName)
        {
            locationName = inLocationName;
        }
        public void setStreetNumName(string inStreetNumName)
        {
            streetNumName = inStreetNumName;
        }
        public void setCounty(string inCounty)
        {
            county = inCounty;
        }
        public void setPostCode(string inPostCode)
        {
            postCode = inPostCode;
        }
        public void setLatitude(double inLatitude)
        {
            latitude = inLatitude;
        }
        public void setLongitude(double inLongitude)
        {
            longitude = inLongitude;
        }
        public void setNumOfYears(int inNumOfYears)
        {
            numOfYears = inNumOfYears;
        }
        public void setYear(Year inYear, int idYear)
        {
            years[idYear] = inYear;
        }

        //gettters
        public int getLoactionNum()
        {
            return locationNum;
        }
        public string getLocationName()
        {
            return locationName;
        }
        public string getStreetNumName()
        {
            return streetNumName;
        }
        public string getCounty()
        {
            return county;
        }
        public string getPostCode()
        {
            return postCode;
        }
        public double getLatitude()
        {
            return latitude;
        }
        public double getLongitude()
        {
            return longitude;
        }
        public int getNumOfYears()
        {
            return numOfYears;
        }
        public Year getYear(int idYear)
        {
            return years[idYear];
        }
    }
}
