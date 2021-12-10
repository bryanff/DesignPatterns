using DesignPatterns.AbstractFactory.v2.Elements.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2.Elements.House
{
    public class ElfsTower : AbstractHouse
    {
        public ElfsTower() : base() { }
        public ElfsTower(List<IRace> elfs) : base(elfs) { }
        public override void getInfo()
        {
            Console.WriteLine(
                "Elfs Tower. \n" +
                "number of elfs:" + base.getAssignedRace().Count
            );
        }
    }
}
