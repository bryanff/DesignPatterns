using DesignPatterns.Builder.Director;
using DesignPatterns.Builder.ShipBuilder;
using DesignPatterns.Builder.SpaceShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class BuilderProgram
    {
        public static void Run()
        {
            SpaceEngineer engineer = new SpaceEngineer();

            SpaceStationBuilder spaceBuilder = new SpaceStationBuilder();
            engineer.constructSpaceStation(spaceBuilder);
            SpaceStation spaceStatation =  spaceBuilder.getResult();
            spaceStatation.getInfo();
         
            RocketBuilder rocketBuilder = new RocketBuilder();
            engineer.constructRocket(rocketBuilder);
            Rocket rocket = rocketBuilder.getResult();
            rocket.getInfo();
        }
    }
  
 
}
