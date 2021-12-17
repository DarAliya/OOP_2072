using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_OOP_2021
{
    class Coal_Cart : Figure
    {
        // перепутано название, тут везется уголь

        Rectangle rectangle;
        Cart cart;
        public Coal_Cart(int x, int y, int heigth, int width) : base(x, y)
        {
            cart = new Cart(x, y, heigth, width);
            rectangle = new Rectangle(x + width/10, y - heigth/3, heigth/3, width - width/5);
        }
        public override void Draw(Graphics graphics)
        {
            cart.Draw(graphics);
            rectangle.Draw(graphics);
            return;
        }
        public override bool Property(int x, int y)
        {
            return true;
        }
    }
}
