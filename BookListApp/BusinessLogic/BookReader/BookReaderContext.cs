using BookListApp.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookListApp.Models;

namespace BookListApp.BusinessLogic
{
    public class BookReaderContext : IBookReaderContext
    {
        private IBookReaderStrategy strategy;

        public BookReaderContext(IBookReaderStrategy bookReaderStrategy)
        {
            strategy = bookReaderStrategy;
        }
        public IList<BookModel> ReadBook(string[] lines)
        {
            return strategy.ReadBook(lines);
        }
    }
}