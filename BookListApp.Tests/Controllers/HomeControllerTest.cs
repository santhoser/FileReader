using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookListApp;
using BookListApp.Controllers;
using BookListApp.Models;

namespace BookListApp.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTest
    {
        [TestMethod()]
        public void IndexTest()
        {
            HomeController controller = new HomeController();
            Assert.IsNotNull(controller);
        }
    }
}

