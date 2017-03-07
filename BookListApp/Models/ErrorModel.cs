using System.Collections.Generic;
using BookListApp.BusinessLogic;

namespace BookListApp.Models
{
    public class ErrorModel
    {
        public ErrorTypes ErrorCode { get; set; }
        public string Message { get; set; }
        public string SystemException { get; set; }
    }
}