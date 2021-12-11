using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Driver
{
    class CSVDriver : IDriver
    {
        private readonly Logger logger = Logger.Instance;
        public void read(string filename)
        {
            logger.info("Reading CSV file...");
        }

        public void write(string filename, string content)
        {
            logger.info("Writing CSV file...");
        }
    }
}
