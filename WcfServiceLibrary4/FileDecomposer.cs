using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WcfServiceLibrary4
{

    public class FileListDecomposer
    {
        private string fileName;
        private string descritption;
        private long size;

        public FileListDecomposer(string _fileName, string _descritption, long _size)
        {
            fileName = _fileName;
            descritption = _descritption;
            size = _size;
        }
    }
}
