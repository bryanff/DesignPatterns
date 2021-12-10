using DesignPatterns.AbstractFactory.v2.Elements.City;
using DesignPatterns.AbstractFactory.v2.Elements.House;
using DesignPatterns.AbstractFactory.v2.Elements.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2.Factory
{
    public class ElfsFactory : IElementFactory
    {
        public AbstractCity createCity(List<AbstractHouse> houses)
        {
            return new ElfsCity(houses);
        }

        public AbstractHouse createHouse(List<IRace> elfs)
        {
            return new ElfsTower(elfs);
        }

        public IRace createRace()
        {
            return new Elf();
        }
    }
}
