using System.Drawing;

namespace Graphics_OOP_2021
{
    abstract class Figure
    {
        private int x;
        private int y;
        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Draw(Graphics g);
        public abstract bool Property(int x, int y);      
    }
}
