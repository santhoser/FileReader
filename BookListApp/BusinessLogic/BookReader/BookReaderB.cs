using BookListApp.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookListApp.Models;

namespace BookListApp.BusinessLogic
{
    public class BookReaderB : BookReader
    {
        public BookReaderB()
        {
            name = new ColumnSeprator(1, 30);
            isbn = new ColumnSeprator(31, 51);
            author = new ColumnSeprator(52, 72);
        }
    }
}