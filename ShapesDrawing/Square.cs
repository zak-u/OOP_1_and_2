using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapesDrawing
{
    class Square : Rectangle
    {
        public Square(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) {}

        public override int Width
        {
            get
            {
                return Height;
            }
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, topLeft.X, topLeft.Y, Width, Width);
        }
    }
}
