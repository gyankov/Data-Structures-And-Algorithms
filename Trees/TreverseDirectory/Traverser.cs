using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreverseDirectory
{
    class Traverser
    {
        public static void ProccessDirectory(string path)
        {
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (file.EndsWith(".exe"))
                {
                    ProcessFile(file);
                }
            }

            var directiories = Directory.GetDirectories(path);
            foreach (var directory in directiories)
            {
                ProccessDirectory(directory);
            }
        }

        private static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
