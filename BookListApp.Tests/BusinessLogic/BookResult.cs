using BookListApp.Models;
using System.Collections.Generic;

namespace BookListApp.Tests.BusinessLogic
{
    public static class BookResult
    {
        public static BookViewModel ExpectedResult
        {
            get
            {
                BookViewModel book = new BookViewModel() { Books = new List<BookModel>(), Errors = new List<ErrorModel>() };
                book.Books.Add(new BookModel("The Test1A", "45311115653", "Roger Zelazny"));
                book.Books.Add(new BookModel("The Test2A", "78711114344", "Neil Gaiman"));
                book.Books.Add(new BookModel("The Test3A", "34511113344", "Jo Walton"));
                book.Books.Add(new BookModel("The Test1B", "4334445345564", "Peter S. Beagle"));
                book.Books.Add(new BookModel("The Test2B", "7567564545454", "Tim Powers"));
                book.Books.Add(new BookModel("The Test3B", "4545454545454", "Piers Anthony"));
                return book;
            }
        }
    }
}
