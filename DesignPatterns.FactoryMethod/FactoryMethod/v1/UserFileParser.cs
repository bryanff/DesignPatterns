using DesignPatterns.FactoryMethod.Driver;
using DesignPatterns.FactoryMethod.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class UserFileParser
    {
        private CsvDriver createCsvDriver()
        {
            return new CsvDriver();
        }

        public void getUsers(string filename)
        {
            CsvDriver driver = this.createCsvDriver();
            driver.read(filename);
        }
    }

    
}
