using BookListApp.Models;
using System.Collections.Generic;

namespace BookListApp.BusinessLogic.Interface
{
    /// <summary>
    /// Strategy Pattern - Logic selection at runtime.
    /// </summary>
    public interface IBookReaderStrategy
    {
        IList<BookModel> ReadBook(string[] lines);

    }
}
