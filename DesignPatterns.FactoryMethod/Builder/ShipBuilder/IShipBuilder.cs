using DesignPatterns.Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.ShipBuilder
{
    public interface IShipBuilder
    {
        public IShipBuilder buildEngine(List<Engine> engines);
        public IShipBuilder buildControlPanel(List<ControlPanel> controls);
        public IShipBuilder buildPassengers(int number);
        public IShipBuilder buildFuelTanks(List<FuelTank> tanks);
    }
}
