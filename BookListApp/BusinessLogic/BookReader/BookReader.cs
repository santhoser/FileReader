using BookListApp.BusinessLogic.Interface;
using BookListApp.Models;
using System;
using System.Collections.Generic;

namespace BookListApp.BusinessLogic
{
    public abstract class BookReader : IBookReaderStrategy
    {
        protected ColumnSeprator name;
        protected ColumnSeprator isbn;
        protected ColumnSeprator author;
        public IList<BookModel> ReadBook(string[] lines)
        {
            IList<BookModel> bookList = new List<BookModel>();

            BookModel bookRecord = new BookModel();
            int lineNumber = 0;
            foreach (string line in lines)
            {
                lineNumber += 1;
                string tempLine = ReplaceTabWithWhiteSpace(line.Trim());
                if (tempLine.Length > author.Start + 1)
                {

                    bookRecord = new BookModel();
                    bookRecord.Name = GetSubString(tempLine, name.Start, name.End);
                    bookRecord.ISBN = GetSubString(tempLine, isbn.Start, isbn.End);
                    bookRecord.Author = GetSubString(tempLine, author.Start, author.End);
                    bookList.Add(bookRecord);
                }
                else {
                    if (lineNumber != 1 && tempLine.Length > 0)
                    {
                        ErrorHandler.AddError(ErrorTypes.ER1, new Exception("Length Error"));
                    }
                    else continue;
                } ;
            }
            return bookList;
        }

        private string GetSubString(string line, int start, int end)
        {
            try
            {
                end = (end > line.Length) ? line.Length : end;
                line = line.Substring(start, (end - start));
                line = line.Trim();
            }
            catch (Exception ex)
            {
                ErrorHandler.AddError(ErrorTypes.ER2, ex);
            }
            return line;
        }

        private string ReplaceTabWithWhiteSpace(string line)
        {
            try
            {
                string tabSpace = new String(' ', 8);
                line = line.Replace("\t", tabSpace);
            }
            catch (Exception ex)
            {
                ErrorHandler.AddError(ErrorTypes.ER3, ex);
            }
            return line;
        }
    }
}