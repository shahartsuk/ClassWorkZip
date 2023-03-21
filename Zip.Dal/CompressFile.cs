using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace Zip.Dal
{
    public class CompressFile
    {
        public CompressFile() { }
        
        //function get path of file or folder and compress them to a zip file
        public string CompressForEachPath(string pathToCompress) 
        {
            string zipPath = "";
            int lastIndex;
            try
            {
                //check if the path is for file or folder
                if (pathToCompress.Contains("."))
                {
                    lastIndex = pathToCompress.LastIndexOf('.');

                    // remove the Extension of the file
                    zipPath = pathToCompress.Remove(lastIndex) + ".zip";

                    //compress file to zip
                    using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                    {
                        archive.CreateEntryFromFile(pathToCompress, Path.GetFileName(pathToCompress));
                    }
                }
                else
                {
                    //compress folder to zip
                    zipPath = pathToCompress + ".zip";
                    ZipFile.CreateFromDirectory(pathToCompress, zipPath);
                }

                return "The operation was successful";
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return "An local error pls try again";
            }
            
            
        }
    }
}
