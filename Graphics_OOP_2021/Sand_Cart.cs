using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_OOP_2021
{
    class Sand_Cart : Figure
    {
        Point point1, point2, point3;
        Point[] p;
        Cart cart;
        SolidBrush yellow = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);
        public Sand_Cart(int x, int y, int heigth, int width) : base(x, y)
        {
            point1 = new Point(x, y);
            point2 = new Point(x + width, y);
            point3 = new Point(x + width / 2, y - heigth / 3);
            p = new Point[] {point1, point2, point3};
            cart = new Cart(x, y, heigth, width);
        }
        public override void Draw(Graphics graphics)
        {   
            graphics.FillPolygon(yellow, p);
            graphics.DrawPolygon(pen, p);
            cart.Draw(graphics);
            return;
        }
        public override bool Property(int x, int y)
        {
            return true;
        }
    }
}
