using DesignPatterns.FactoryMethod.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.v2.Parser
{
    public abstract class FileParser
    {
        protected abstract IDriver createDriver();
        public abstract void parse(string filepath);
    }
}


