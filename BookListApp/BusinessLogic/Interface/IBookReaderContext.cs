using BookListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListApp.BusinessLogic.Interface
{
    public interface IBookReaderContext
    {
        IList<BookModel> ReadBook(string[] lines);
    }
}
