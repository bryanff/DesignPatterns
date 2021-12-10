using DesignPatterns.Builder.Parts;
using DesignPatterns.Builder.ShipBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Director
{
    class SpaceEngineer
    {
        public void constructRocket(IShipBuilder builder)
        {
            List<Engine> engines = new List<Engine>() { new Engine(), new Engine() };
            List<ControlPanel> controls = new List<ControlPanel>() { new ControlPanel(), new ControlPanel() };
            List<FuelTank> tanks = new List<FuelTank>() { new FuelTank(), new FuelTank() };

            builder.buildEngine(engines)
                   .buildControlPanel(controls)
                   .buildFuelTanks(tanks)
                   .buildPassengers(5);
        }

        public void constructSpaceStation(IShipBuilder builder)
        {
            List<Engine> engines = new List<Engine>() { new Engine() };
            List<ControlPanel> controls = new List<ControlPanel>() { new ControlPanel() };
            List<FuelTank> tanks = new List<FuelTank>() { new FuelTank(), new FuelTank() };

            builder.buildEngine(engines)
                   .buildControlPanel(controls)
                   .buildFuelTanks(tanks)
                   .buildPassengers(10);
        }
    }
}
