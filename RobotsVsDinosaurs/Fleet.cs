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
        public List<Weapon> armory; 

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
            armory = new List<Weapon>();
            Weapon weapon = new Weapon("Blaster Rifle", 12);
            Weapon weapon1 = new Weapon("Energy Knife", 5);
            Weapon weapon2 = new Weapon("Gatling Cannon", 18);
            armory.Add(weapon);
            armory.Add(weapon1);
            armory.Add(weapon2);
        }

        //memeber methods
    }
}
