using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AssignmentGUI
{
    class DLLFunctions
    {
        private const string dllFilePath = @"C://Users/Dell/Documents/visual studio 2012/Projects/AssignmentGUI/AssignmentGUI/Assignment.dll";

        [DllImport(dllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static double CalculateCircleLength(double radius);

        [DllImport(dllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static double CalculateCircleArea(double radius);

        [DllImport(dllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static double CalculateRectangleLength(double P1X, double P1Y, double P2X, double P2Y);

        [DllImport(dllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static double CalculateRectangleArea(double P1X, double P1Y, double P2X, double P2Y);

        [DllImport(dllFilePath, CallingConvention = CallingConvention.Cdecl)]
        private extern static double CalculateLineLength(double P1X, double P1Y, double P2X, double P2Y);

        public static Tuple<double, double> GetCircleProperties(Circle circle)
        {
            return new Tuple<double, double>(CalculateCircleLength(circle.Radius), CalculateCircleArea(circle.Radius));
        }

        public static Tuple<double, double> GetRectangleProperties(Rectangle rectangle)
        {
            return new Tuple<double, double>(CalculateRectangleLength(rectangle.LengthSide.Item1, rectangle.LengthSide.Item2, rectangle.WidthSide.Item1, rectangle.WidthSide.Item2), CalculateRectangleArea(rectangle.LengthSide.Item1, rectangle.LengthSide.Item2, rectangle.WidthSide.Item1, rectangle.WidthSide.Item2));
        }

        public static double GetLineProperties(Line line)
        {
            return CalculateLineLength(line.P1.Item1, line.P1.Item2, line.P2.Item1, line.P2.Item2);
        }
    }
}
