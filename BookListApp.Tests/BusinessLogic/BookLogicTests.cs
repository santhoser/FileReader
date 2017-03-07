using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookListApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookListApp.Tests.BusinessLogic;
using BookListApp.Models;

namespace BookListApp.BusinessLogic.Tests
{
    [TestClass()]
    public class BookLogicTests
    {
        [TestMethod()]
        public void GetBookListTest()
        {
            // Injecting the Fake File Reader
            BookLogic logic = new BookLogic(new FakeFileReader());
            BookViewModel actualResult = logic.GetBookList();
            BookViewModel expectedResult = BookResult.ExpectedResult;
            Assert.IsNotNull(actualResult.Books);
            Assert.IsNotNull(expectedResult.Books);
            Assert.AreEqual(expectedResult.Books[0].Author, actualResult.Books[0].Author);
            Assert.AreEqual(expectedResult.Books[0].Name, actualResult.Books[0].Name);
            Assert.AreEqual(expectedResult.Books[0].ISBN, actualResult.Books[0].ISBN);
        }
    }
}