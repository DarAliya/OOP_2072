using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_OOP_2021
{
    class Figure
    {
        protected int x; // координаты фигуры
        protected int y;

        public virtual void Draw(Graphics graphics/*, int x, int y*/)
        {
            //return;
        }
    }
}
