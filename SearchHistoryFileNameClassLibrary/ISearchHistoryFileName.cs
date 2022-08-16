using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHistoryFileNameClassLibrary
{
    public interface ISearchHistoryFileName
    {
        List<string> SearchHistory(String FileName);
    }
}
