using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(-1, 4, "Point1");
            Point point2 = new Point(-1, 2, "Point2");
            Point point3 = new Point(-7, 3, "Point3");
            Point point4 = new Point(-8, 12, "Point4");
            Point point5 = new Point(-2, 7, "Point5");
            Figure figure1 = new Figure(point1, point2, point3);
            Console.WriteLine("Имя фигуры - " + figure1.Name);
            figure1.PerimeterCalculator();
            Console.WriteLine("Периметр фигуры - " + figure1.Perimetr);
            Console.WriteLine(new string('-',50));
            Figure figure2 = new Figure(point1, point2, point3,point4);
            Console.WriteLine("Имя фигуры - " + figure2.Name);
            figure2.PerimeterCalculator();
            Console.WriteLine("Периметр фигуры - " + figure2.Perimetr);
            Console.WriteLine(new string('-', 50));
            Figure figure3 = new Figure(point1, point2, point3, point4, point5);
            Console.WriteLine("Имя фигуры - " + figure3.Name);
            figure3.PerimeterCalculator();
            Console.WriteLine("Периметр фигуры - " + figure3.Perimetr);
            Console.ReadKey();
        }
    }
}
