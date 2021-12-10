using DesignPatterns.Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.SpaceShips
{
    class Rocket
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
                "\nShip: Rocket" +
                "\nNumber Engines: " + this.Engines.Count +
                "\nNumber Control Panels: " + this.Controls.Count +
                "\nNumber Fuel Tanks: " + this.Tanks.Count +
                "\nNumber Passengers: " + this.Passengers
            );
        }
    }
}
