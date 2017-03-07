using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookListApp.Models
{
    public class BookViewModel
    {
        public List<BookModel> Books { get; set; }
        public List<ErrorModel> Errors { get; set; }
    }
}