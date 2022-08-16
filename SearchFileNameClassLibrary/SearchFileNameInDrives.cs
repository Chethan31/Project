using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveAllFilesAndDirectoryClassLibrary;
using SplitPathToFileNameClassLibrary;
using SearchHistorySaveAndReadDataClassLibrary;
using SearchHistoryFileNameClassLibrary;

namespace SearchFileNameClassLibrary
{
    public class SearchFileNameInDrives : ISearchFIleNameInDrives
    {
        public List<string> SearchFileName(string fileName)
        {
            ISearchHistoryFileName search = new SearchHistoryFileName();
            int flag = 0;
            //int f = 0;
            List<string> files = new List<string>();
            List<string> listOfFilePath = new List<string>();
            IDriveAllFilesAndDirectory classDrive = new DriveAllFilesAndDirectory();
            listOfFilePath = classDrive.AllFilesAndDirectory();
            ISplitPathToFileName SPN = new SplitPathToFileName();
            ISaveAndReadData SR = new SaveAndReadData();
            foreach (string file in listOfFilePath)
            {
                if (fileName == SPN.SplitPath(file))
                {
                    //Console.WriteLine(file);
                    SR.SaveData(file);
                    files.Add(file);
                    flag = 1;
                }
            }
            if (flag == 0)
                return null;
            else
                return files;
        }
    }
}
