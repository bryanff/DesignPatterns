using DesignPatterns.Decorator.ModeDecorators;
using DesignPatterns.Decorator.Modes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class DecoratorProgram
    {
        public static void Run()
        {
            string username = "SPbryan";
            DarkMode darkmode = new DarkMode(new BaseNormalMode());
            UserNameDisplayer displayer = new UserNameDisplayer(darkmode);
            displayer.displayUsername(username);
        }
    }
}
