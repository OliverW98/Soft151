using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft151assignment
{
    public class Year
    {
        private int year;
        private string yearDescription;
        private Month[] months;

        //constructor
        public Year(string inYearDescription, int inYear)
        {
            months = new Month[12];
            year = inYear;
            yearDescription = inYearDescription;
        }

        //setters
        public void setYear(int inYear)
        {
            year = inYear;
        }
        public void setYearDescription(string inYearDescription)
        {
            yearDescription = inYearDescription;
        }
        public void setMonth(Month inMonth, int monthId)
        {
            months[monthId] = inMonth;
        }

        //getters
        public int getYear()
        {
            return year;
        }
        public string getYearDescription()
        {
            return yearDescription;
        }
        public Month getMonth(int monthId)
        {
            return months[monthId];
        }
        public int numberMonths()
        {
            return months.Length;
        }
    }
}
