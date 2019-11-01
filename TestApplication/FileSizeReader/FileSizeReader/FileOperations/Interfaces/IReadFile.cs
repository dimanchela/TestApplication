using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations.Interfaces
{
    public interface IReadFile
    {
        ReadFileResult ReadFile(string filePath);
    }
}
