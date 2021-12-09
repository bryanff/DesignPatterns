using DesignPatterns.FactoryMethod.Driver;
using DesignPatterns.FactoryMethod.v2.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v2.Parser
{
    class XMLFileParser : FileParser
    {
        protected override IDriver createDriver() { return new XMLDriver(); }
        public override void parse(string filepath)
        {
            IDriver driver = this.createDriver();
            driver.read(filepath);
            Console.WriteLine("Parsing a XML file..");
        }
    }
}
