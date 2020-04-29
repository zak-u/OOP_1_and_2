using System;
using System.Drawing;

namespace ShapesDrawing
{
    class Circle : Ellipse
    {
        public Circle(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) {}

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, Width, Width);
        }
    }
}
