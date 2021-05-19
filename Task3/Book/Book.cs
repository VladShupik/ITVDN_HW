using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        Title title;
        Author author;
        Content content;
        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public Book() 
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }
        public string Title 
        {
            set
            {
                this.title.TitleProperty = value;
            }
        }
        public string Author
        {
            set
            {
                this.author.AuthorProperty = value;
            }
        }
        public string Content
        {
            set
            {
                this.content.ContentProperty = value;
            }
        }

    }
}
