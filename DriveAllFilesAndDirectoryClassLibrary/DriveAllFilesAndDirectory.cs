using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveFinderClassLibrary;
using DirectoryAndFileLoopClassLibrary;

namespace DriveAllFilesAndDirectoryClassLibrary
{
    public class DriveAllFilesAndDirectory : IDriveAllFilesAndDirectory
    {
        public List<string> AllFilesAndDirectory()
        {
            IDriveFinder driveFinder = new DriveFinder();
            List<string> drives = driveFinder.GetDriveInfo();
            List<string> allFile = new List<string>();
            foreach (string drive in drives)
            {
                if (drive == @"D:\")
                {
                    // Console.WriteLine(drive);
                    ISubLoopDirectoryAndFile sub = new SubLoopDirectoryAndFile();
                    allFile = sub.SubDirectoryandFile(drive);
                }
            }
            return allFile;
        }
    }
}
