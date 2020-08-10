using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
   public class Fleet
    {
        //member variables
        public List<Robot> fleets;

        //constructor
        public Fleet()
        {
            fleets = new List<Robot>();
            Robot robot1 = new Robot("Battle Droid", 100, 50, 12, "Blaster Rifle");
            Robot robot2 = new Robot("Assassin Droid", 80, 50, 5, "Energy Knife");
            Robot robot3 = new Robot("Juggernaut Droid", 120, 50, 18, "Gattling Cannon");
            fleets.Add(robot1);
            fleets.Add(robot2);
            fleets.Add(robot3);
        }

        //memeber methods
        public Fleet CreateFleet()
        {
            Fleet fleet = new Fleet();

            return fleet;
        }
        public void PopulateFleet(Robot fleet)
        {
            fleets.Add(fleet);
        }
    }
}
