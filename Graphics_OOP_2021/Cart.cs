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
        //int x_wh1 = 0;
        //int x_wh2 = 0;
        //int y_wh1 = 0;
        //int y_wh2 = 0;
        //int rad = 20;

        Rect rectangle;
        Circle wheel1;
        Circle wheel2;

      
        public Cart(int x, int y, int heigth, int width) : base(x, y)
        {
            rectangle = new Rect (x, y, heigth, width);
            int rad = width / 5;
            wheel1 = new Circle(x, y + heigth, rad);
            wheel2 = new Circle(x + width - rad, y + heigth, rad);
        }

        public override void Draw(Graphics graphics)
        {
            rectangle.Draw(graphics);
            wheel1.Draw(graphics);
            wheel2.Draw(graphics);
            return;
        }
        public override bool Property(int x, int y)
        {
            return true;
        }
    }
}
