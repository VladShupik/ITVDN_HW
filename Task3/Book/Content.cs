using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Content
    {
        private string content = null;
        public string ContentProperty
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Нет содержания.";
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ContentProperty);
        }
    }
}
