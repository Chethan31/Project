using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFinderInDriveClassLibrary
{
    public class DirectoryFinder : IDirectoryFinder
    {
        public List<string> GetDirectoryInfo(string drive)
        {
            List<string> directory = new List<string>();
            foreach (var dir in Directory.GetDirectories(drive))
            {
                directory.Add(dir);
            }
            return directory;
        }
    }
}
