﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="Title 1", Price = 4 },
                new Book() {Title="Title 2", Price = 9 },
                new Book() {Title="Title 3", Price = 15 }

            };
        }

    }
}
