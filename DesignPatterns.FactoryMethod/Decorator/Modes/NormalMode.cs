using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Modes
{
    public class BaseNormalMode : IMode
    {
        public string applyMode(string username)
        {
            return username;
        }
    }
}
