
using DesignPatterns.AbstractFactory.v2.Elements.House;
using DesignPatterns.AbstractFactory.v2.Elements.Race;
using DesignPatterns.AbstractFactory.v2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2
{
    public class ApplicationV2
    {
        private readonly IElementFactory _factory;
        public ApplicationV2(IElementFactory factory) => this._factory = factory;

        public void main()
        {
            this.buildCity(this.generateHouses(10));
        }
        private List<IRace> populate()
        {
            List<IRace> races = new List<IRace>()
            {
                this._factory.createRace(),
                this._factory.createRace(),
            };
            return races;
        }

        private List<AbstractHouse> generateHouses(int number)
        {
            List<AbstractHouse> houses = new List<AbstractHouse>();
            for (int i = 0; i < number-1; i++)
            {
                houses.Add(this._factory.createHouse(this.populate()));
            }
            return houses;
        }
        private void buildCity(List<AbstractHouse> houses)
        {
            this._factory.createCity(houses);
        }
    }
}
