using System.Drawing;

namespace ShapesDrawing
{
    abstract class Shape
    {
        public Point firstPoint, secondPoint;
        public Pen pen;

        public Shape(Pen pen, Point firstPoint, Point secondPoint)
        {
            this.pen = pen;
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
        }

        public abstract void Draw(Graphics graphic);
    }
}
