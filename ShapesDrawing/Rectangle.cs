using System;
using System.Drawing;

namespace ShapesDrawing
{
    class Rectangle : Shape
    {
        public Rectangle(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) { }

        public virtual int Width
        {
            get
            {
                return Math.Abs(secondPoint.X - firstPoint.X);
            }
        }

        public int Height
        {
            get
            {
                return Math.Abs(secondPoint.Y - firstPoint.Y);
            }
        }
        public Point topLeft
        {
            get
            {
                int x = Math.Min(firstPoint.X, secondPoint.X);
                int y = Math.Min(firstPoint.Y, secondPoint.Y);
                return new Point(x, y);
            }
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, topLeft.X, topLeft.Y, Width, Height);
        }
    }
}
