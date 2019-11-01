using FileOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public class GetPathAllFiles : IGetFilesPath
    {
        List<string> _filesPath = new List<string>();
        public List<string> GetFilesPath(string dirPath)
        {
            foreach (string file in Directory.GetFiles(dirPath).ToList<string>())
            {
                _filesPath.Add(file);
            }
            foreach (string subDir in Directory.GetDirectories(dirPath))
            {
                GetFilesPath(subDir);
            }
            return _filesPath;
        }
    }
}
