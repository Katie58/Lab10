using System;

namespace Lab10
{
    public class Circle
    {
        const double pi = Math.PI;
        private double radius;
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }

        public Circle(double radius)
        {
            Console.WriteLine($"Creating a circle with {radius} radius!");        
        }

        public double CalculateCircumference()
        {
            double circumference = 2 * pi * radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            double circumference = CalculateCircumference();
            return "The circumference is " + FormatNumber(circumference);
        }

        public double CalculateArea()
        {
            double area = pi * Math.Pow(radius, 2);
            return area;
        }

        public string CalculateFormattedArea()
        {
            double area = CalculateArea();
            return "The area is " + FormatNumber(area);
        }

        private string FormatNumber(double x)
        {
            return x.ToString("#.##");
        }
    }
}
