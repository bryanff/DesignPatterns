using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v1
{
    class CsvDriver
    {
        public void read(string filename)
        {
            Console.WriteLine("reading file..");
        }
        public  void write(string filename, string content)
        {
            Console.WriteLine("Writing file..");
        }
    }
}
