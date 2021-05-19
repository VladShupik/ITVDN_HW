using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Show();
            Console.WriteLine(new string ('-', 50));
            book1.Title = "CLR via C#";
            book1.Author = "Jeffrey Richter";
            book1.Content = "Учебник по программированию";
            book1.Show();
            Console.ReadKey();
        }
    }
}
