using DesignPatterns.AbstractFactory.v2.Elements.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2.Elements.City
{
    class OrcsCity : AbstractCity
    {
        public OrcsCity(List<AbstractHouse> caves) : base(caves) { }
        public override void getInfo()
        {
            Console.WriteLine(
                "Orcs city. \n" +
                "number of caves: " + base.getHouses.Count
            );
        }
    }
}
