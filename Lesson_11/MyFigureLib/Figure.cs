using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFigureLib
{
    public class Figure
    {
        // points array
        private Point[] points;
        public Point[] Points
        {
            get { return points; }
        }

        // figure name
        private string name;
        public string Name
        {
            get { return name; }
        }

        public Figure(string name)
        {
            this.name = name;
        }
        public Figure(Point p1, Point p2, Point p3, string name) : this(name)
        {
            points = new Point[3] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, string name) : this(name)
        {
            points = new Point[4] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5, string name) : this(name)
        {
            points = new Point[5] { p1, p2, p3, p4, p5 };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public double PerimeterCalculator()
        {
            // points - 3 P1, P2, P3  -  P1P2 + P2P3 + P3P1
            // points - 4 P1, P2, P3, P4
            // points - 5 P1, P2, P3, P4, P5

            double perimeter = LengthSide(points[0], points[points.Length - 1]);
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            return perimeter;
        }

        public override string ToString()
        {
            return $"{Name} - perimeter = {PerimeterCalculator()}";
        }
    }
}
