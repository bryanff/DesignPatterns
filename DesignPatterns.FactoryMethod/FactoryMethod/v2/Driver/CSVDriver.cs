using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Driver
{
    class CSVDriver : IDriver
    {
        public void read(string filename)
        {
            Console.WriteLine("Reading CSV file...");
        }

        public void write(string filename, string content)
        {
            Console.WriteLine("Writing csv file...");
        }
    }
}
