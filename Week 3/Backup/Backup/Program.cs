using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    class Program
    {
        static void Main(string[] args)
        {
            BackupFolder();
            Console.ReadLine();
        }

        private static void BackupFolder()
        {
            // create zip file using current date
            using (FileStream zipToOpen = File.Open(DateTime.Now.ToString() + Directory.GetCurrentDirectory() 
                + ".zip", FileMode.Create))
            {
                // create archive 
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                {
                    // get list of files to be zipped, using current directory
                    var fileList = Directory.GetFiles((Directory.GetCurrentDirectory()));

                    // loop through each file in current directory and zip
                    foreach (var file in fileList)
                    {
                        archive.CreateEntryFromFile(file, file);
                    }

                // back up new zip file to folder
                    // FINISH - REPLACE NAME WITH NAME OF BACKUP DIRECTORY? NOW USING MSDN STRING NAME
                archive.ExtractToDirectory(Directory.GetCurrentDirectory());
                }
            }
        }
    }
}
