using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookListApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookListApp.BusinessLogic.Interface;
using BookListApp.Tests.BusinessLogic;
using System.IO;

namespace BookListApp.BusinessLogic.Tests
{
    [TestClass()]
    public class FileReaderTests
    {
        [TestMethod()]
        public void IsDirectoryExistsTest()
        {
            IFileReader reader = new FakeFileReader();
            bool isDirectoryExists = Directory.Exists(reader.ServerPath);
            Assert.IsTrue(isDirectoryExists);
        }
        
    }
}