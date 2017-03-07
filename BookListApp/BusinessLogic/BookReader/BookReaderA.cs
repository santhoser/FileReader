using BookListApp.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookListApp.Models;

namespace BookListApp.BusinessLogic
{
    public class BookReaderA : BookReader
    {
        public BookReaderA()
        {
            name = new ColumnSeprator(1, 20);
            isbn = new ColumnSeprator(21, 41);
            author = new ColumnSeprator(42, 62);
        }
    }
}