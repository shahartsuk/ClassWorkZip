using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using Zip.Dal;

namespace Zip.Entities
{
    public class CompressManager
    {
        CompressFile compressFile = new CompressFile();

        public string InitCompress(string sourcePath)
        {
            return compressFile.CompressForEachPath(sourcePath);
        }
    }
}
