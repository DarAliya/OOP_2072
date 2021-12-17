using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graphics_OOP_2021
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        List<Figure> figures = new List<Figure>();

       /*Graphics graphics = new Graphics();*/
        private void button1_Click(object sender, EventArgs e)

        {
            int rect_x = 10;
            int rect_y = 15;
            int rect_width = 200;
            int rect_height = 200;
            Rectangle rect = new Rectangle(rect_x, rect_y, rect_height, rect_width);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Figure fig in figures)
            {
                //fig.Draw();
            }
        }
    }
}
