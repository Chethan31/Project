using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveAllFilesAndDirectoryClassLibrary;
using SplitPathToFileNameClassLibrary;

namespace SearchFileNameClassLibrary
{
    public class SearchFileNameInDrives : ISearchFIleNameInDrives
    {
        public void SearchFileName(string fileName)
        {
            int flag = 0;
            int f = 0;
            List<string> listOfFilePath = new List<string>();
            IDriveAllFilesAndDirectory classDrive = new DriveAllFilesAndDirectory();
            listOfFilePath=classDrive.AllFilesAndDirectory();
            ISplitPathToFileName SPN = new SplitPathToFileName();
            foreach(string file in listOfFilePath)
            {
                if (fileName == SPN.SplitPath(file))
                {
                    if(f == 0)
                        Console.WriteLine("File Found in Path....");
                    Console.WriteLine(file);
                    f = 1;
                    flag = 1;
                }
                //Console.WriteLine(SPN.SplitPath(file));
            }
            if(flag == 0)
                Console.WriteLine("File Not Found....");
        }
    }
}
