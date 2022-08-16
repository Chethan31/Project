using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchFileNameClassLibrary;
using SearchHistoryFileNameClassLibrary;

namespace SearchEngine
{
    public class SearchFile
    {
        public static void Search(string FileName)
        {
            ISearchHistoryFileName SH = new SearchHistoryFileName();
            List<string> FoundFileInHistory = new List<string>();
            FoundFileInHistory=SH.SearchHistory(FileName);
            if (FoundFileInHistory != null)
            {
                Console.WriteLine("File Found in History...");
                foreach (string FoundFileItem in FoundFileInHistory)
                    Console.WriteLine(FoundFileItem);
            }
            else
            {
                ISearchFIleNameInDrives search = new SearchFileNameInDrives();
                List<string> FoundFileInPath = new List<string>();
                FoundFileInPath = search.SearchFileName(FileName);
                if (FoundFileInPath != null)
                {
                    Console.WriteLine("File Found in Path...");
                    foreach (string FoundFileItem in FoundFileInPath)
                        Console.WriteLine(FoundFileItem);
                }
                else
                {
                    Console.WriteLine("File Not Found...");
                }
            }   
        }
    }
}
