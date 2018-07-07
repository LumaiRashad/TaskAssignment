using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssignmentGUI
{
    public partial class Paint : Form
    {
        #region  Declarations Region    
        public Circle circle;
        public Line line;
        public Rectangle rectangle;
        #endregion

        #region Constructors Region      
        public Paint()
        {
            InitializeComponent();
            circle = new Circle();
            line = new Line();
            rectangle = new Rectangle();
        }
        #endregion

        private void LineBtn_Click(object sender, EventArgs e)
        {
            Input1 lineForm = new Input1();
            lineForm.ShowDialog();
            line.P1 = new Tuple<double, double>(lineForm.getX1(), lineForm.getY1());
            line.P2 = new Tuple<double, double>(lineForm.getX2(), lineForm.getY2());
            double lineProb = DLLFunctions.GetLineProperties(line);
            LineLengthTextBox.Text = lineProb.ToString();
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            Input2 circleForm = new Input2();
            circleForm.ShowDialog();
            circle.Radius = circleForm.getRadius();
            circle.Center = new Tuple<double, double>(circleForm.getX1(), circleForm.getY1());
            var circleProp = DLLFunctions.GetCircleProperties(circle);
            CircleLengthTextBox.Text = circleProp.Item1.ToString();
            CircleAreaTextBox.Text = circleProp.Item2.ToString();
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            Input1 rectangleForm = new Input1();
            rectangleForm.ShowDialog();
            rectangle.LengthSide = new Tuple<double, double>(rectangleForm.getX1(), rectangleForm.getY1());
            rectangle.WidthSide = new Tuple<double, double>(rectangleForm.getX2(), rectangleForm.getY2());
            var rectangleProp = DLLFunctions.GetRectangleProperties(rectangle);            
            RectangleLengthTextBox.Text = rectangleProp.Item1.ToString();
            RectangleAreaTextBox.Text = rectangleProp.Item2.ToString();            
        }

       
    }
}
