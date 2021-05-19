using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Figure
    {
        string name;
        double perimetr;
        Point[] points;
        public Figure(Point point1, Point point2, Point point3)
        {
            this.name = "Треугольник";
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.name = "Четырехугольник";
            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.name = "Пятиугольник";
            points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point5;
        }
        public string Name{ get{return name;} }
        public double LengthSide(Point A, Point B)
        {
            double side = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return side;
        }
        public void PerimeterCalculator()
        {
            double[] sides = new double[points.Length];
            for (int i = 0; i < sides.Length; i++)
            {
                if (i + 1 == sides.Length)
                {
                    sides[i] = LengthSide(points[0], points[i]);
                }
                else
                {
                    sides[i] = LengthSide(points[i], points[i + 1]);
                }
            }
            for (int i = 0; i < sides.Length; i++)
            {
                perimetr += sides[i];
            }
        }
        public double Perimetr { get { return perimetr;  } }
    }
}
