using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Graphics_OOP_2021
{
    class Circle : Figure
    {
        //int x;
        //int y; //class rectangle x y width height 
        int raduis;
        Pen bkPen = new Pen(Color.Black);
        public Circle(int x, int y, int rad)
        {
            this.x = x;
            this.y = y;
            this.raduis = rad;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(bkPen, x, y, raduis, raduis);
        }
    }
}
