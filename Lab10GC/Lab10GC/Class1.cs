using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10GC
{
    class Circle
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateCircumference()
        {
            return Radius * 2 * Math.PI;
        }
        public string CalculateFormattedCircumference(double num)
        {
            return FormatNumber(num);
        }
        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
        public string CalculateFormattedArea(double num)
        {
            return FormatNumber(num);
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
