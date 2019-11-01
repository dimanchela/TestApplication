using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations.Interfaces
{
    public interface IGetFilesPath
    {
        List<string> GetFilesPath(string dirPath);
    }
}
