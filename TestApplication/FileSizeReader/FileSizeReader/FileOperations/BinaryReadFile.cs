using FileOperations.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    public class BinaryReadFile : IReadFile
    {
        public ReadFileResult ReadFile(string filePath)
        {
            try
            {
                int partSize = 1024;
                byte[] sizeSimbols = new byte[partSize];
                ulong size = 0;
                var readFile = new ReadFileResult() { Name = filePath };
                using (var binReader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    while (binReader.BaseStream.Position != binReader.BaseStream.Length)
                    {
                        sizeSimbols = binReader.ReadBytes(partSize);
                        for (int x = 0; x < sizeSimbols.Length; x++)
                        {
                            size += sizeSimbols[x];
                        }
                    }
                    readFile.ByteSize = size;
                }
                return readFile;
            }
            catch (Exception ex) 
            {
                return new ReadFileResult() { Name = filePath, ByteSize = 0, ErrorMessage = ex.Message };
            }
        }
    }
}
