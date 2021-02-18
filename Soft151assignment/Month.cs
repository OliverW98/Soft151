using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft151assignment
{
    public class Month
    {
        private int monthIdNumber;
        private double maximumTemp;
        private double minimumTemp;
        private double numberOfDaysOfAirFrost;
        private double milsOfRainFall;
        private double hoursOfSunShine;

        //constructor
        public Month(int inMonthIdNumber, double inMaxTemp, double inMinTemp, double inNumOfFrost, double inMilOfRainFall, double inHoursOfSun)
        {
            monthIdNumber = inMonthIdNumber;
            maximumTemp = inMaxTemp;
            minimumTemp = inMinTemp;
            numberOfDaysOfAirFrost = inNumOfFrost;
            milsOfRainFall = inMilOfRainFall;
            hoursOfSunShine = inHoursOfSun;
        }

        // setters
        public void setMonthIdNumber(int inMonthIdNumber)
        {
            monthIdNumber = inMonthIdNumber;
        }
        public void setMaximumTemp(double inMaxTemp)
        {
            maximumTemp = inMaxTemp;
        }
        public void setMinimumTemp(double inMinTemp)
        {
            minimumTemp = inMinTemp;
        }
        public void setNumberOfDaysOfAirFrost(double inNumOfFrost)
        {
            numberOfDaysOfAirFrost = inNumOfFrost;
        }
        public void setMilsOfRainFall(double inMilOfRainFall)
        {
            milsOfRainFall = inMilOfRainFall;
        }
        public void setHoursOfSunShine(double inHoursOfSun)
        {
            hoursOfSunShine = inHoursOfSun;
        }

        //getters
        public int getMonthIdNumber()
        {
            return monthIdNumber;
        }
        public double getMaximumTemp()
        {
            return maximumTemp;
        }
        public double getMinimumTemp()
        {
            return minimumTemp;
        }
        public double getNumberOfDaysOfAirFrost()
        {
            return numberOfDaysOfAirFrost;
        }
        public double getMilsOfRainFall()
        {
            return milsOfRainFall;
        }
        public double getHoursOfSunShine()
        {
            return hoursOfSunShine;
        }

        public override string ToString()
        {
            return getMonthIdNumber()+": "+"\t" +"Max temp: " + getMaximumTemp()+ "\t" + "Min Temp: " + getMinimumTemp() + "\t" + "Frost Days: " + getNumberOfDaysOfAirFrost() + "\t" + "Mils Of Rain: " + getMilsOfRainFall() + "\t" + " Hours Of Sun: " + getHoursOfSunShine();
        }
    }
}
