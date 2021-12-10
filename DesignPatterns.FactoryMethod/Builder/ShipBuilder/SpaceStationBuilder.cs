using DesignPatterns.Builder.Parts;
using DesignPatterns.Builder.SpaceShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.ShipBuilder
{
    class SpaceStationBuilder : IShipBuilder
    {
        private readonly SpaceStation _spaceShip =  new SpaceStation();
        public IShipBuilder buildControlPanel(List<ControlPanel> controls)
        {
            this._spaceShip.Controls = controls;
            return this;
        }
        public IShipBuilder buildEngine(List<Engine> engines)
        {
            this._spaceShip.Engines = engines;
            return this;
        }
        public IShipBuilder buildFuelTanks(List<FuelTank> tanks)
        {
            this._spaceShip.Tanks = tanks;
            return this;
        }
        public IShipBuilder buildPassengers(int number)
        {
            this._spaceShip.Passengers = number;
            return this;
        }
        public SpaceStation getResult() => this._spaceShip;
    }
}
