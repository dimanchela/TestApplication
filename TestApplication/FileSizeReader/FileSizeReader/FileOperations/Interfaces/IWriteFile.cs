using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations.Interfaces
{
    public interface IWriteFile
    {
        void WriteFile(string filePath, BindingList<ReadFileResult> filesSize);
    }
}
