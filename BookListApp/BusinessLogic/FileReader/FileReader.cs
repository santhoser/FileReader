using BookListApp.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace BookListApp.BusinessLogic
{
    public class FileReader : IFileReader
    {
        /// <summary>
        /// Folder path - Hard coded
        /// </summary>
        public string ServerPath
        {
            get { return HostingEnvironment.MapPath("~/Data"); }
        }

        /// <summary>
        /// Acceptable Extensions - Hard coded
        /// </summary>
        public string Extension
        {
            get { return "*.txt"; }
        }

        /// <summary>
        /// Get the list of all files in the location
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllFiles()
        {
            IEnumerable<string> filesList = Directory.EnumerateFiles(ServerPath, Extension);
            return filesList;
        }
        /// <summary>
        /// Reads all the lines in the file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string[] ReadTheFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                return lines;
            }
            catch (Exception ex)
            {
                ErrorHandler.AddError(ErrorTypes.ER5, ex);
                return new string[0];
            }
        }

        /// <summary>
        /// Read the first line of file the File format
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string GetFileFormat(string filePath)
        {
            string fileFormat = string.Empty;
            using (StreamReader fileStream = new StreamReader(filePath))
            {
                fileFormat = fileStream.ReadLine() ?? "";
            }
            return fileFormat;
        }
    }
}