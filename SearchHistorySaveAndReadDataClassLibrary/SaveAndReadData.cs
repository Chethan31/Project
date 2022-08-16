using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHistorySaveAndReadDataClassLibrary
{
    public class SaveAndReadData : ISaveAndReadData
    {
        public List<string> ReadData()
        {
            List<string> data = new List<string>();
            StreamReader reader = new StreamReader("D:/Search History.txt");
            while (!reader.EndOfStream)
            {
                data.Add(reader.ReadLine());
              //  Console.WriteLine(name);
            }
            reader.Close();
            return data;
        }

        public void SaveData(string path)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter("D:/Search History.txt", true);
                writer.WriteLine(path);
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
