using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab2A
{
    class MyDate
    {
        private int year, month, day;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public MyDate(int newYear, int newMonth, int newDay)
        {
            Year = newYear;
            Month = newMonth;
            Day = newDay;
        }

        public MyDate ()
        {
            Year = -1;
            Month = -1;
            Day = -1;
        }

        public override string ToString()
        {
            return Month + "/" + Day + "/" + Year;
        }
    }
}
