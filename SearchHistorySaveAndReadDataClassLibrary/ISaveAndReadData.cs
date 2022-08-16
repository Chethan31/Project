using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHistorySaveAndReadDataClassLibrary
{
    public interface ISaveAndReadData
    {
        List<string> ReadData();
        void SaveData(string path);
    }
}
