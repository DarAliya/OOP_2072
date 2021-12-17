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
        public virtual int Heigth
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
        public virtual int Width
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
        public Rect(int x, int y, int height, int width) : base(x, y)
        {
            this.h = height;
            this.w = width;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, X, Y, Width, Heigth);
        }
        public override bool Property(int x, int y)
        {
            return true;
        }
    }
}
