using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinderInDriveClassLibrary
{
    public class FileFinder : IFileFinder
    {
        public List<string> GetFileInfo(string Drive)
        {
            List<string> files = new List<string>();
            foreach (var file in Directory.GetFiles(Drive))
            {
                files.Add(file);
            }
            return files;
        }
    }
}
