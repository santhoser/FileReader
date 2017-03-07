using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookListApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using BookListApp.Models;
using BookListApp.Tests.BusinessLogic;
using Newtonsoft.Json;

namespace BookListApp.Controllers.Tests
{
    [TestClass()]
    public class BookApiControllerTests
    {
        [TestMethod()]
        public void ApiGetTest()
        {
            BookApiController api = new BookApiController(new FakeFileReader());
            var expectedResult = BookResult.ExpectedResult.Books;
            JsonResult<BookViewModel> result = api.Get();
            var actualResult = result.Content.Books;
            
            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(expectedResult);
            Assert.AreEqual(expectedResult[0].Author, actualResult[0].Author);
        }
        
    }
}