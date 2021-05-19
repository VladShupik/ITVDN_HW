using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Title
    {
        private string title = null;
        public string TitleProperty
        {
            private get
            {
                if (title != null)
                    return title;
                else
                    return "Нет названия книги.";
            }
            set
            {
                title = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(TitleProperty);
        }
    }
}
