using DesignPatterns.FactoryMethod.Driver;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v2.Driver
{
    class XMLDriver : IDriver
    {
        private readonly Logger logger = Logger.Instance;
        public void read(string filename)
        {
            logger.info("Reading XML file...");
        }
        public void write(string filename, string content)
        {
            logger.info("Writing XML file...");
        }
    }
}
