using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Driver
{
    public interface IDriver
    {
        public void read(string filename);
        public void write(string filename, string content);
    }
}
