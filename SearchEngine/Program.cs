using DriveFinderClassLibrary;
using FileFinderInDriveClassLibrary;
using DirectoryFinderInDriveClassLibrary;
using DirectoryAndFileLoopClassLibrary;

namespace SearchEngine
{
    internal class Prgram
    {
        public static void Main()
        {
            Console.WriteLine("Hello, Welcome to our File Search Engine");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Available Drives in our system");
            IDriveFinder driveFinder = new DriveFinder();
            List<string> drives = driveFinder.GetDriveInfo();
            foreach(string drive in drives)
            {
                Console.WriteLine(drive);
                ISubLoopDirectoryAndFile sub = new SubLoopDirectoryAndFile();
                sub.SubDirectoryandFile(drive);
            }
            Console.WriteLine("----------------------------------------");
           
            
           
        }
    }
}