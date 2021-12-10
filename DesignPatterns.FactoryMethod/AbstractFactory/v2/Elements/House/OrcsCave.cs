using DesignPatterns.AbstractFactory.v2.Elements.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2.Elements.House
{
    public class OrcsCave : AbstractHouse
    {
        public OrcsCave() : base() { }
        public OrcsCave(List<IRace> orcs) : base(orcs) { }
        public override void getInfo()
        {
            Console.WriteLine(
                "Orcs cave. \n" +
                "number of Orcs:" + base.getAssignedRace().Count
            );
        }
    }
}
