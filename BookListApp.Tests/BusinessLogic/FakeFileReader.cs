using BookListApp.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace BookListApp.Tests.BusinessLogic
{
    public class FakeFileReader : IFileReader
    {
        public string ServerPath
        {
            get
            {
                return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\BookListApp\\Data";
            }
        }

        public string Extension { get { return "*.txt"; } }
        public IEnumerable<string> GetAllFiles()
        {
            IEnumerable<string> fakeFileName = new List<string> {
                "A.txt", "B.txt"
            };
            return fakeFileName;
        }

        public string GetFileFormat(string filePath)
        {
            string fakeFormat = string.Empty;
            switch (filePath)
            {
                case "A.txt":
                    fakeFormat = "A";
                    break;
                case "B.txt":
                    fakeFormat = "B";
                    break;
                case "C.txt":
                    fakeFormat = "C";
                    break;
                default:
                    fakeFormat = "Z";
                    break;
            }
            return fakeFormat;
        }

        public string[] ReadTheFile(string filePath)
        {
            List<string> fakeLines = new List<string>();
            switch (filePath)
            {
                case "A.txt":
                    fakeLines.Add("A");
                    fakeLines.Add("The Test1A          45311115653          Roger Zelazny");
                    fakeLines.Add("The Test2A          78711114344          Neil Gaiman");
                    fakeLines.Add("The Test3A          34511113344          Jo Walton");
                    break;
                case "B.txt":
                    fakeLines.Add("B");
                    fakeLines.Add("The Test1BFile                4334445345564        Peter S. Beagle");
                    fakeLines.Add("The Test2BFile                7567564545454        Tim Powers");
                    fakeLines.Add("The Test3BFile                4545454545454        Piers Anthony");
                    break;
                case "C.txt":
                    fakeLines.Add("C");
                    fakeLines.Add("The Test1C          45322225653          Roger Zelazny");
                    fakeLines.Add("The Test2C          78722224344          Neil Gaiman");
                    fakeLines.Add("The Test3C          34522223344          Jo Walton");
                    break;
                default:
                    fakeLines.Add("Z");
                    break;
            }
            return fakeLines.ToArray();
        }
    }
}
