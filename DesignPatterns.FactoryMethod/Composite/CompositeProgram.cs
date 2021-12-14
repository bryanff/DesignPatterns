using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class CompositeProgram
    {
        public static void Run()
        {
            List<IDocument> subdocuments = new List<IDocument>()
            {
                new File("sub_doc_1.txt")
            };
            List<IDocument> documents = new List<IDocument>()
            {
                new File("doc_1.txt"),
                new Directory(subdocuments, "subfolder")
            };
            Directory directory = new Directory(documents,"main_folder");
            directory.show("/");
        }
    }
}
