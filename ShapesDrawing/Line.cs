using System.Drawing;

namespace ShapesDrawing
{
    class Line : Shape
    {
        public Line(Pen pen, Point firstPoint, Point secondPoint) : base(pen, firstPoint, secondPoint) {}

        public override void Draw(Graphics graphic)
        {
            graphic.DrawLine(pen, firstPoint, secondPoint);
        }
    }

}
