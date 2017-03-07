using BookListApp.BusinessLogic.Interface;
using BookListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookListApp.BusinessLogic
{
    public class BookLogic
    {
        private IFileReader fileReader;
        private BookReaderFactory factory;
        private IBookReaderContext context;

        /// <summary>
        /// Constructor Injection for FileReader
        /// </summary>
        /// <param name="fileRead"></param>
        public BookLogic(IFileReader fileRead)
        {
            fileReader = fileRead;
            factory = new BookReaderFactory();
        }
        
        
        public BookViewModel GetBookList()
        {
            BookViewModel viewModel = new Models.BookViewModel();
            try
            {
                List<BookModel> bookList = new List<BookModel>();
                IEnumerable<string> fileList = fileReader.GetAllFiles();
                foreach (var file in fileList)
                {
                    string fileFormat = fileReader.GetFileFormat(file).ToUpper();
                    context = factory.CreateContext(fileFormat);
                    if (context != null)
                    {
                        string[] lines = fileReader.ReadTheFile(file);
                        bookList.AddRange(context.ReadBook(lines));
                    }
                }

                viewModel.Books = bookList;
                viewModel.Errors = ErrorHandler.ErrorList;
               
            }
            catch (Exception e)
            {
                ErrorHandler.AddError(ErrorTypes.ER0, e);
                viewModel.Errors = ErrorHandler.ErrorList;
            }
            return viewModel;
        }
    }
}