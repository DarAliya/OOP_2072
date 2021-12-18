using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_OOP_2021
{
    class Cart : Figure
    {
        Rect rect;
        Circle w1;
        Circle w2;      
        public Cart(int x, int y, int h, int w) : base(x, y)
        {
            rect = new Rect (x, y, h, w);
            int r = w / 5;
            w1 = new Circle(x, y + h, r);
            w2 = new Circle(x + w - r, y + h, r);
        }
        public override void Draw(Graphics g)
        {
            rect.Draw(g);
            w1.Draw(g);
            w2.Draw(g);
            return;
        }
    }
}
