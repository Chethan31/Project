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
        public void SubDirectoryandFile(string path)
        {
            IDirectoryFinder directoryFinder = new DirectoryFinder();
            List<string> dir = directoryFinder.GetDirectoryInfo(path);
            foreach (string d in dir)
            {
                try
                {
                    Console.WriteLine($"Directory {d}");
                    IFileFinder fileFinder = new FileFinder();
                    List<string> files = fileFinder.GetFileInfo(d);
                    foreach (string file in files)
                    {
                        Console.WriteLine($"file:{file}");
                    }
                    SubDirectoryandFile(d);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
