using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Directory : IDocument
    {
        private string _name;
        private readonly List<IDocument> _documents;
        public Directory(List<IDocument> documents, string name)
        {
            _name = name;
            _documents = documents;
        }
        public void show(string path)
        {
            path += "/" + this._name;
            Console.WriteLine($"{path}");
            foreach (IDocument item in _documents)
            {
                item.show(path);
            }
        }
    }
}
