using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFileNameClassLibrary
{
    public interface ISearchFIleNameInDrives
    {
        List<string> SearchFileName(string fileName);
    }
}
