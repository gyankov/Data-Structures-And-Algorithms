using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TreverseDirectory
{
    class Program
    {        
        static void Main(string[] args)
        {
            var folder = new Folder { Name = "D:\\" };
            ProccessDirectory(folder.Name, folder);
        }

        private static void ProccessDirectory(string path, Folder folder)
        {
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                folder.Files.Add(new File { Name = file, Size = new FileInfo(file).Length });
            }

            var directiories = Directory.GetDirectories(path);
            foreach (var directory in directiories)
            {
                var newFolder = new Folder { Name = directory};
                ProccessDirectory(directory, newFolder);
            }
        }
        
        private static long GetTotalSize(Folder folder)
        {
            long sum = 0;
            foreach (var file in folder.Files)
            {
                sum += file.Size;
            }
            foreach (var fold in folder.Folders)
            {
                sum += GetTotalSize(fold);
            }

            return sum;            
        }        
    }
}
