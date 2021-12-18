using System;
using System.Drawing;


namespace Graphics_OOP_2021
{
    class Circle : Figure
    {
        int r;
        Pen Pen = new Pen(Color.Red);
        public Circle(int x, int y, int r) : base(x, y)
        {
            this.r = r;
        }
        public int R
        {
            get
            {
                if (r <= 0)
                {
                    return r * (-1);
                }
                else
                {
                    return r;
                }
            }
            set
            {
                r = value;
            }
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pen, X, Y, r, r);
        }
    }
}
