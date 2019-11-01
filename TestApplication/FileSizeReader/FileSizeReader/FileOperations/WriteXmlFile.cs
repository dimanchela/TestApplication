using FileOperations.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileOperations
{
    public class WriteXmlFile : IWriteFile
    {
        public void WriteFile(string filePath, BindingList<ReadFileResult> filesSize)
        {
            if (filesSize == null)
                return;

            if (File.Exists($"{filePath}\\FileSizes.xml"))
                File.Delete($"{filePath}\\FileSizes.xml");

            XDocument xdoc = new XDocument();
            XElement xFileSize = new XElement("FilesSize");
            foreach (var file in filesSize)
            {
                XElement xfile = new XElement("File");
                XAttribute xname = new XAttribute("Name", file.Name);
                XElement xsize = new XElement("Size", file.ByteSize);
                XElement xerror = new XElement("ErrorMessage", file.ErrorMessage);

                xfile.Add(xname, xsize, xerror);
                xFileSize.Add(xfile);
            }
            xdoc.Add(xFileSize);
            xdoc.Save($"{filePath}\\FileSizes.xml");
        }
    }
}
