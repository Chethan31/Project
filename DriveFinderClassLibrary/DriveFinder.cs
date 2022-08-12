using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveFinderClassLibrary
{
    public class DriveFinder : IDriveFinder
    {
        public List<string> GetDriveInfo()
        {
            List<string> drives = new List<string>();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                drives.Add(drive.Name);
            }
            return drives;
        }
    }
}
