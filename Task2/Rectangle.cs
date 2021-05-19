using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        private double side1, side2, area, perimetr;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        public double Perimetr
        {
            get
            {
                return perimetr;
            }
        }
        public double AreaCalculator()
        {
            area = side1 * side2;
            return area;
        }
        public double PerimetrCalculator()
        {
            perimetr = 2 * (side1 + side2);
            return perimetr;
        }
    }
}
