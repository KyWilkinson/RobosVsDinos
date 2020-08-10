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
        public List<Fleet> inventory;

        //constructor
        public Fleet()
        {
            inventory = new List<Fleet>();
            Robot robot1 = new Robot("Battle Droid", 100, 50, 12, "Blaster Rifle");
            Robot robot2 = new Robot("Assassin Droid", 80, 50, 5, "Energy Knife");
            Robot robot3 = new Robot("Juggernaut Droid", 120, 50, 18, "Gattling Cannon");
            inventory.Add(robot1);
            inventory.Add(robot2);
            inventory.Add(robot3);
        }

        //memeber methods
        public Fleet CreateFleet(string name, int health, int powerLevel, int attackPower, string weaponType)
        {
            Fleet fleet = new Fleet(name, health, powerLevel, attackPower, weaponType);

            return fleet;
        }
        public void PopulateFleet(Fleet inventory)
        {
            
        }
    }
}
