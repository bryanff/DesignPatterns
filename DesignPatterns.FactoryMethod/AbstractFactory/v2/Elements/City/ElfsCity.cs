using DesignPatterns.AbstractFactory.v2.Elements.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2.Elements.City
{
    public class ElfsCity : AbstractCity
    {
        public ElfsCity(List<AbstractHouse> towers) : base(towers){}
        public override void getInfo()
        {
            Console.WriteLine(
                "Elfs city. \n" +
                "number of towers: " + base.getHouses.Count
            );
        }
    }
}
