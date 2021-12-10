using DesignPatterns.AbstractFactory.v2.Elements.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2.Elements.City
{
    public abstract class AbstractCity
    {
        private readonly List<AbstractHouse> _houses;
        public AbstractCity(List<AbstractHouse> houses) {  }
        protected List<AbstractHouse> getHouses => _houses;
        protected void addHouse(AbstractHouse house) { this._houses.Add(house); }
        public abstract void getInfo();
    }
}
