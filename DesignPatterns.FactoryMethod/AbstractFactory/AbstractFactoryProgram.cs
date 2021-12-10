using DesignPatterns.AbstractFactory.v2;
using DesignPatterns.AbstractFactory.v2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryProgram
    {
        public static void Run()
        {
            // V2 - applying abstract factory design pattern
            ApplicationV2 app2 = new ApplicationV2(new OrcsFactory());
            app2.main();
        }
    }
}
