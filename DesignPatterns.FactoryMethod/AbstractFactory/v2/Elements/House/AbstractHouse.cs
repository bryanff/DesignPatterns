using DesignPatterns.AbstractFactory.v2.Elements.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.v2.Elements.House
{
    public abstract class AbstractHouse
    {
        private List<IRace> _races;
        protected AbstractHouse() => this._races = new List<IRace>();
        protected AbstractHouse(List<IRace> races) => this._races = races;
        public List<IRace> getAssignedRace() => this._races;
        public void AddRace(IRace race) => this._races.Add(race);
        public abstract void getInfo();
    }
}
