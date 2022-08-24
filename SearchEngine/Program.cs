using DriveFinderClassLibrary;
 namespace SearchEngine
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, Welcome to our File Search Engine");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Available Drives in my System");
            IDriveFinder driveFinder = new DriveFinder();
            List<string> drives = driveFinder.GetDriveInfo();
            foreach (string drive in drives)
            {
                Console.WriteLine(drive);
            }
            Console.WriteLine("----------------------------------------");
            Console.Write("Enter a FileName To be Searched:");
            string FileName = Console.ReadLine();
            
            SearchFile.Search(FileName);
        }
    }
}