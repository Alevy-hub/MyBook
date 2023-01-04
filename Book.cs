using System;
using System.Collections.Generic;
using System.Text;

namespace MyBook
{
    public class Book
    {
        public string name;
        public string id;

        public Book(string bookId, string bookName)
        {
            id = bookId;
            name = bookName;
        }

    }
}
