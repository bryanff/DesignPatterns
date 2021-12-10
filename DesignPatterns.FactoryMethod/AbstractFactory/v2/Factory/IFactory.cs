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
    public interface IElementFactory
    {
        public IRace createRace();
        public AbstractHouse createHouse(List<IRace> race);
        public AbstractCity createCity(List<AbstractHouse> houses);
    }
}
