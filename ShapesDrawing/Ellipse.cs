using System.Drawing;

namespace ShapesDrawing
{
    class Ellipse : Rectangle
    {
        public Ellipse(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) {}

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, topLeft.X, topLeft.Y, Width, Height);
        }
    }
}
