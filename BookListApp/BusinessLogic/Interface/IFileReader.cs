using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListApp.BusinessLogic.Interface
{
    public interface IFileReader
    {
        string ServerPath { get; }
        string Extension { get; }
        IEnumerable<string> GetAllFiles();
        string[] ReadTheFile(string filePath);
        string GetFileFormat(string filePath);
    }
}
