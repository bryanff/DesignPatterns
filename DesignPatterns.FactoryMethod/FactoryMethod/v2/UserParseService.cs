using DesignPatterns.FactoryMethod.v2.Parser;
using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v2
{
    class UserParseService
    {
        private readonly FileParser _parser;
        public UserParseService(FileParser parser) => this._parser = parser ;
        public void getUsers(string filepath)
        {
            Logger.Instance.debug("Parsing File...");
            this._parser.parse(filepath);
        }
    }
}
