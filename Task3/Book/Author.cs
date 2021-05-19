using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Author
    {
        private string author = null;
        public string AuthorProperty 
        {
            private get
            {
                if (author != null)
                    return author;
                else
                    return "Автор отсутствует.";
            }
            set
            {
                author = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(AuthorProperty);
        }
    }
}
