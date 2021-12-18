using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace OOP_4
{
    class MyDate
    {
        protected int date;
        protected int month;
        protected int year;
        protected int[] days;
        public int Date
        {
            get { return date; }
            set { date = value; }

        }
        public int Month
        {
            get { return month; }
            set { month = value; }
             
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public MyDate(int date, int month, int year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
            this.days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        }
        public void NextDate()
        {
            if((Date == days[Month - 1])&&(Month==12))
            {
                Month=1;
                Date = 1;
                Year++;
            }
            else if(Date == days[Month - 1])
            {
                Month++;
                Date = 1;
            }
            else { Date++; }
        }
        public void visokos()
        {
            if(Year%400==0)
            {
               this.days[1] = 29;
            }
            else if(Year % 100 == 0)
            {
                this.days[1] = 28;
            }
            else if (Year % 4 == 0)
            {
                this.days[1] = 29;
            }
            else { this.days[1] = 28; }
        }
        public string Visuald()
        {
            string t = Date.ToString();
            return t;
        }
        public string Visualm()
        {
            string t = Month.ToString();
            return t;
        }
        public string Visualy()
        {
            string t = Year.ToString();
            return t;
        }
        public bool IsValid()
        {
            if ((Month == 2) && (((Year % 4 == 0) && (Date > 29)) || ((Year % 4 != 0) && (Date > 28))))
            {
                Date = 22;
                Month = 11;
                Year = 2021;
                return false;
            }
            else if ((Date <= 0) || (Date > 31) || (Month <= 0) || (Month > 12) || (Year <= 0))
            {
                Date = 22;
                Month = 11;
                Year = 2021;
                return false;
            }
            else if (Date > days[Month - 1])
            {
                Date = 22;
                Month = 11;
                Year = 2021;
                return false;
            }
            else { return true; }
            
        }
    }
}
