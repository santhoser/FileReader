using BookListApp.BusinessLogic.Interface;
using BookListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookListApp.BusinessLogic
{
    /// <summary>
    /// Factory Pattern - Building Objects
    /// </summary>
    public class BookReaderFactory
    {
        private IBookReaderContext context;

        public IBookReaderContext CreateContext(string fileType)
        {
            switch (fileType)
            {
                case "A":
                    context = new BookReaderContext(new BookReaderA());
                    break;
                case "B":
                    context = new BookReaderContext(new BookReaderB());
                    break;
                default:
                    ErrorHandler.AddError(ErrorTypes.ER4, new Exception("Incorrect File format" + fileType));
                    break;
            }
            return context;
       }
    }
}
