using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public interface ILog
    {
        public void error(string message);
        public void info(string message);
        public void debug(string message);
        public void warning(string message);

    }
}
