using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Modes
{
    public interface IMode
    {
        public string applyMode(string username);
    }
}
