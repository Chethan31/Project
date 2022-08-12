using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitPathToFileNameClassLibrary
{
    public class SplitPathToFileName : ISplitPathToFileName
    {
        public string SplitPath(string path)
        {
            string filename=null;
            string[] file = path.Split(@"\");

            foreach (string s in file)
            {
               // Console.WriteLine(s);
                filename = s;
            }
           // Console.WriteLine(filename);
            return filename;
        }
    }
}
