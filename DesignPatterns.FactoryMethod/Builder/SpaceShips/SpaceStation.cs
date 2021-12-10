using DesignPatterns.Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.SpaceShips
{
    class SpaceStation
    {
        private List<Engine> engines;
        private List<ControlPanel> controls;
        private List<FuelTank> tanks;
        private int passengers;
        public List<Engine> Engines { get => engines; set => engines = value; }
        public List<ControlPanel> Controls { get => controls; set => controls = value; }
        public List<FuelTank> Tanks { get => tanks; set => tanks = value; }
        public int Passengers { get => passengers; set => passengers = value; }
        public void getInfo()
        {
            Console.WriteLine(
                "\n Ship: SpaceStation" +
                "\n Number Engines: " + this.Engines.Count +
                "\n Number Control Panels: " + this.Controls.Count +
                "\n Number Fuel Tanks: " + this.Tanks.Count +
                "\n Number Passengers: " + this.Passengers
            );
        }
    }
}
