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
        protected string proverka;
        public int DATE
        {
            get { return date; }
            set { date = value; }

        }
        public int MONTH
        {
            get { return month; }
            set { month = value; }
             
        }
        public int YEAR
        {
            get { return year; }
            set { year = value; }
        }
        public string Proverka
        {
            get { return proverka; }
            set { proverka = value; }
        }
        public MyDate(int date, int month, int year, string proverka)
        {
            this.date = date;
            this.month = month;
            this.year = year;
            this.days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            this.proverka = proverka;
        }
        public void NextDate()
        {
            
            if((DATE == days[MONTH - 1])&&(MONTH==12))
            {
                MONTH=1;
                DATE = 1;
                YEAR++;
            }
            else if(DATE == days[MONTH - 1])
            {
                MONTH++;
                DATE = 1;
            }
            else { DATE++; }
        }
        public void visokos()
        {
            if(YEAR%4==0)
            {
                this.days[1] = 29;
            }
            else { this.days[1] = 28; }
        }
        public void Visual(TextBox date, TextBox month, TextBox year, Label proverka)
        {
            date.Text = DATE.ToString();
            month.Text = MONTH.ToString();
            year.Text = YEAR.ToString();
            proverka.Text = Proverka;
        }
        public void IsValid()
        {
            if ((MONTH == 2) && (((YEAR % 4 == 0) && (DATE > 29)) || ((YEAR % 4 != 0) && (DATE > 28))))
            {
                Proverka = "Неверный формат даты";
                DATE = 22;
                MONTH = 11;
                YEAR = 2021;
            }
            else if ((DATE <= 0) || (DATE > 31) || (MONTH <= 0) || (MONTH > 12) || (YEAR <= 0))
            {
                Proverka = "Неверный формат даты";
                DATE =22;
                MONTH = 11;
                YEAR = 2021;
            }
            else if (DATE > days[MONTH - 1])
            {
                Proverka = "Неверный формат даты";
                DATE =22;
                MONTH = 11;
                YEAR = 2021;
            }
            else { Proverka = ""; }
            
        }
    }
}
