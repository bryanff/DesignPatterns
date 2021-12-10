using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2.Elements.Race
{
    public class Elf : IRace
    {
        public void fight()
        {
            Console.WriteLine("Elf fighting....");
        }
    }
}
