using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class File : IDocument
    {
        private string _filename;
        public File(string filename) => _filename = filename;
        public void show(string path)
        {
            Console.WriteLine($"{path}/{_filename}");
        }
    }
}
