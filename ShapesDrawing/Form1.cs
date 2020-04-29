using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesDrawing
{
    public partial class fmShapeDrawing : Form
    {
        Graphics graphic;
        Point startPoint, finishPoint;
        Color color;
        Pen pen;
        int tag = 3;
        int thickness = 1;
        Dictionary<int, Shape> shapesDict = new Dictionary<int, Shape>();
        List<Shape> shapes = new List<Shape>();
     
        public fmShapeDrawing()
        {
            InitializeComponent();
        }
        private void pbDrawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            finishPoint.X = e.X;
            finishPoint.Y = e.Y;
            ChooseObject();
            shapes.Add(shapesDict[tag]); 
            foreach (Shape shape in shapes)
            {
                shape.Draw(graphic);
            }
            shapesDict.Clear();
        }

        private void pbDrawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint.X = e.X;
            startPoint.Y = e.Y;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            tag = Convert.ToInt32(button.Tag);
        }

        private void fmShapeDrawing_Load(object sender, EventArgs e)
        {
            graphic = pbDrawingBoard.CreateGraphics();

            startPoint.X = 0;
            startPoint.Y = 0;
            finishPoint.X = 0;
            finishPoint.Y = 0;
            color = Color.Black;
            pen = new Pen(color, thickness);
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            thickness = Convert.ToInt32(cbThickness.Text);
            pen = new Pen(color, thickness);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dRes = ColorDialog.ShowDialog();
            if (dRes == DialogResult.OK)
            {
                pbColor.BackColor = ColorDialog.Color;
                color = ColorDialog.Color;
                pen = new Pen(color, thickness);
            }
        }

      
        private void btnClear_Click(object sender, EventArgs e)
        {
            pbDrawingBoard.Controls.Clear();
            pbDrawingBoard.Invalidate();
            pbDrawingBoard.Update();
            shapes.Clear();   
        }

        private void ChooseObject()
        {
            shapesDict.Add(1, new Circle(pen, startPoint, finishPoint));
            shapesDict.Add(2, new Square(pen, startPoint, finishPoint));
            shapesDict.Add(3, new Rectangle(pen, startPoint, finishPoint));
            shapesDict.Add(4, new Triangle(pen, startPoint, finishPoint));
            shapesDict.Add(5, new Ellipse(pen, startPoint, finishPoint));
            shapesDict.Add(6, new Line(pen, startPoint, finishPoint));
        }   
    }
}
