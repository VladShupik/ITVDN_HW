using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 сторону прямоугольника : ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 сторону прямоугольника : ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            rectangle.AreaCalculator();
            rectangle.PerimetrCalculator();
            Console.WriteLine("Периметр прямоугольника = {0} , Площадь прямоугольника = {1}", rectangle.Perimetr, rectangle.Area);
            Console.ReadKey();
        }
    }
}
