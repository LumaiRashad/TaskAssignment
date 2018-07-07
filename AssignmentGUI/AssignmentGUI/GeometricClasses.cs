using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGUI
{
    public class Circle
    {
        public Tuple<double, double> Center { get; set; } 
        public double Radius { get; set; }

        public double Area { get; set; }
        public double Length { get; set; }
    }

    public class Line
    {
        public Tuple<double, double> P1 {get; set;}
        public Tuple<double, double> P2 {get; set;}

        public double Length { get; set; }
    }

    public class Rectangle
    {
        public Tuple<double, double> LengthSide {get; set;}
        public Tuple<double, double> WidthSide {get; set;}

        public double Area { get; set; }
        public double Length { get; set; }
    }
}
