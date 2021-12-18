using System.Drawing;


namespace Graphics_OOP_2021
{
    class Rect : Figure
    {
        protected int x;
        protected int y;
        protected int h;
        protected int w;
        Pen Pen = new Pen(Color.Blue);
        public virtual int H
        {
            get
            {
                return h;
            }
            set
            {
                if (value <= 0)
                {
                    h = value * (-1);
                }
                else
                {
                    h = value;
                }
            }
        }
        public virtual int W
        {
            get
            {
                return w;
            }
            set
            {
                if (value <= 0)
                {
                    w = value * (-1);
                }
                else
                {
                    w = value;
                }
            }
        }        
        public Rect(int x, int y, int h, int w) : base(x, y)
        {
            this.h = h;
            this.w = w;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, X, Y, W, H);
        }
    }
}
