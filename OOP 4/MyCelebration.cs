using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace OOP_4
{
    class MyCelebration
    {
        
        int date;
        int month;
        int year;
        int[] mas_data;
        int[] mas_month;
        string[] mas_nazvanie;
        string nazvanie;
        //int[] mas_year;
        public MyCelebration(int date, int month, int year)
        {
            mas_data = new int[6] { 24, 1, 20, 13, 27, 1 };
            mas_month = new int[6] { 3, 5, 5, 12, 7, 1 };
            mas_nazvanie = new string[6] { "День компа", "День варенья", "День дизайна", "День здоровья", "День лени", "Мой день"};
            this.date = date;
            this.month = month;
            this.year = year;          

        }
        public void lets_celebrate(Label prazdnik)
        {
            int i2 = 0;
            
                
            for(int i=0; i<mas_data.Length; i++)
            {
                if ((date == mas_data[i]) && (month == mas_month[i]))
                {
                    prazdnik.Text = mas_nazvanie[i];
                    i2 = -1;
                    break;
                }
            }
        }
    }
}
