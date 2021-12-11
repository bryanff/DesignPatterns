using DesignPatterns.FactoryMethod.Driver;
using DesignPatterns.FactoryMethod.v2.Driver;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v2.Parser
{
    class XMLFileParser : FileParser
    {
        private readonly Logger _logger;
        public XMLFileParser() : base()
        {
            _logger = Logger.Instance;
        }
        protected override IDriver createDriver() { return new XMLDriver(); }
        public override void parse(string filepath)
        {
            try
            {
                IDriver driver = this.createDriver();
                driver.read(filepath);
                _logger.info("Parsing XML file");
            }
            catch (FileNotFoundException)
            {
                _logger.debug("File Not found");
            }
            catch (Exception)
            {
                _logger.error("Error trying to reading csv file");
            }
        }
    }
}
