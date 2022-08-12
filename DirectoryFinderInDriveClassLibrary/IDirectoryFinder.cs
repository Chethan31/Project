using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFinderInDriveClassLibrary
{
    public interface IDirectoryFinder
    {
        List<string> GetDirectoryInfo(string drive);
    }
}
