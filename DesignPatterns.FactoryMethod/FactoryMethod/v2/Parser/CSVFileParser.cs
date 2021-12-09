using DesignPatterns.FactoryMethod.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v2.Parser
{
    public class CSVFileParser : FileParser
    {
        protected override IDriver createDriver() { return new CSVDriver(); }
        public override void parse(string filepath)
        {
            IDriver driver = this.createDriver();
            driver.read(filepath);
            Console.WriteLine("Parsing CSV file....");
        }
    }


}
