using DesignPatterns.Builder.Parts;
using DesignPatterns.Builder.SpaceShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.ShipBuilder
{
    class RocketBuilder : IShipBuilder
    {
        private readonly Rocket _rocketShip = new Rocket();
        public IShipBuilder buildControlPanel(List<ControlPanel> controls)
        {
            this._rocketShip.Controls = controls;
            return this;
        }

        public IShipBuilder buildEngine(List<Engine> engines)
        {
            this._rocketShip.Engines = engines;
            return this;
        }

        public IShipBuilder buildFuelTanks(List<FuelTank> tanks)
        {
            this._rocketShip.Tanks = tanks;
            return this;
        }

        public IShipBuilder buildPassengers(int number)
        {
            this._rocketShip.Passengers = number;
            return this;
        }
        public Rocket getResult() => this._rocketShip;
    }
}
