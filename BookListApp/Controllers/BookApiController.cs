using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using BookListApp.Models;
using BookListApp.BusinessLogic;
using BookListApp.BusinessLogic.Interface;

namespace BookListApp.Controllers
{
    public class BookApiController : ApiController
    {
        BookLogic logic;
        // GET api/values
        public BookApiController()
        {
            logic = new BookLogic(new FileReader());
        }

        public BookApiController(IFileReader fileReader)
        {
            logic = new BookLogic(fileReader);
        }
        public JsonResult<BookViewModel> Get()
        {
            BookViewModel books = logic.GetBookList();
            return Json(books);
        }

    }
}
