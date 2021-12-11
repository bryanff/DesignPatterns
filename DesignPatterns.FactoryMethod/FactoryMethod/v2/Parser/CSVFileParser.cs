using DesignPatterns.FactoryMethod.Driver;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v2.Parser
{
    public class CSVFileParser : FileParser
    {
        private readonly Logger _logger;
        public CSVFileParser() : base()
        {
            _logger = Logger.Instance;
        }
        protected override IDriver createDriver() { return new CSVDriver(); }
        public override void parse(string filepath)
        {
            try
            {
                IDriver driver = this.createDriver();
                driver.read(filepath);
                _logger.info("Parsing a CSV File.....");
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
