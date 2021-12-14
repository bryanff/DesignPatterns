using DesignPatterns.Decorator.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class UserNameDisplayer
    {
        private readonly IMode mode;
        public UserNameDisplayer(IMode mode) => this.mode = mode;
        public void displayUsername(string username)
        {
            Console.WriteLine("Username: " + mode.applyMode(username));
        }
    }
}
