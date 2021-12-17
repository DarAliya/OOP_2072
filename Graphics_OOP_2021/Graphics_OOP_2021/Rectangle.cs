using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Graphics_OOP_2021
{
    class Rectangle:Figure
    {
        //int x;
        //int y;
        int height;
        int width;

        Pen bkPen = new Pen(Color.Black);

        public Rectangle(int x, int y, int height, int width)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(bkPen, x, y, width, height);

        }

    }
}
