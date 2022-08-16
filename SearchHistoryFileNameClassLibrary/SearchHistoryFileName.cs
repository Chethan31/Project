using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchHistorySaveAndReadDataClassLibrary;
using SplitPathToFileNameClassLibrary;

namespace SearchHistoryFileNameClassLibrary
{
    public class SearchHistoryFileName : ISearchHistoryFileName
    {
        public List<string> SearchHistory(string FileName)
        {
            int flag = 0;
            List<string> file = new List<string>();
            ISplitPathToFileName split = new SplitPathToFileName();
            List<string> HistoryFile = new List<string>();
            ISaveAndReadData readData = new SaveAndReadData();
            HistoryFile = readData.ReadData();
            foreach (string line in HistoryFile)
            {
                if(FileName == split.SplitPath(line))
                {
                    //Console.WriteLine(line);
                    file.Add(line);
                    flag = 1;
                }
            }
            if (flag == 0)
                return null;
            else
                return file;
        }
    }
}
