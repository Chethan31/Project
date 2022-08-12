using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryAndFileLoopClassLibrary;
using DriveFinderClassLibrary;
using FileFinderInDriveClassLibrary;
using DirectoryFinderInDriveClassLibrary;


namespace DirectoryAndFileLoopClassLibrary
{
    public class SubLoopDirectoryAndFile : ISubLoopDirectoryAndFile
    {
        List<string> AllFiles = new List<string>();
        public List<string> SubDirectoryandFile(string path)
        {
            IFileFinder fileFinder = new FileFinder();
            List<string> files = fileFinder.GetFileInfo(path);
            foreach (string file in files)
            {
                AllFiles.Add(file);
                //Console.WriteLine($"file:{file}");
            }
            IDirectoryFinder directoryFinder = new DirectoryFinder();
            List<string> dir = directoryFinder.GetDirectoryInfo(path);
            foreach (string d in dir)
            {
                try
                {
                    //Console.WriteLine($"Directory {d}");
                    SubDirectoryandFile(d);
                }
                catch (Exception ex)
                {
                }
            }
            return AllFiles;
        }
    }
}
