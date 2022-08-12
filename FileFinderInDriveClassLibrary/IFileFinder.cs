using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinderInDriveClassLibrary
{
    public interface IFileFinder
    {
        List<string> GetFileInfo(string drive);
    }
}
