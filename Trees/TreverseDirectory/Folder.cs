using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreverseDirectory
{
    class Folder
    {
        public Folder()
        {
            this.Files = new List<File>();
            this.Folders = new List<Folder>();
        }
        public string  Name { get; set; }

        public ICollection<File> Files { get; set; }

        public ICollection<Folder> Folders { get; set; }
    }
}
