using DesignPatterns.FactoryMethod.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v2.Driver
{
    class XMLDriver : IDriver
    {
        public void read(string filename)
        {
            Console.WriteLine("Reading XML file...");
        }
        public void write(string filename, string content)
        {
            Console.WriteLine("Writing XML file...");
        }
    }
}
