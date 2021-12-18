using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drobi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int ch1;
            int zn1;
            int ch2;
            int zn2;
            bool result1 = int.TryParse(textBox1.Text, out ch1);
            bool result2 = int.TryParse(textBox2.Text, out zn1);
            bool result3 = int.TryParse(textBox3.Text, out ch2);
            bool result4 = int.TryParse(textBox4.Text, out zn2);
            if (result1 && result2 && result3 && result4)
            {
                int ch1 = Convert.ToInt32(textBox1.Text);
                int zn1 = Convert.ToInt32(textBox2.Text);
                int ch2 = Convert.ToInt32(textBox3.Text);
                int zn2 = Convert.ToInt32(textBox4.Text);
                Rational r3 = new Rational();
                if (zn1 == 0 || zn2 == 0)
                {
                    textBox5.Text = "Вычисления невозможны так как знаменатель равен 0";
                    return;
                }
                Rational r1 = new Rational(ch1, zn1);
                Rational r2 = new Rational(ch2, zn2);
                if (label6.Text == "+")
                {
                    r3 = r1 + r2;
                }
                if (label6.Text == "/")
                {
                    r3 = r1 / r2;
                }
                if (label6.Text == "-")
                {
                    r3 = r1 - r2;
                }
                if (label6.Text == "*")
                {
                    r3 = r1 * r2;
                }
                textBox5.Text = Convert.ToString(r3);
            }
            else
            {
                textBox5.Text = "Вычисления невозможны так как введены неверные значения";
            }
            
              
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = "*";
        }
    }
}
