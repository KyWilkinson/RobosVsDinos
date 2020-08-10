using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        //member variables
        public string robotName;
        public int robotHealth;
        public int robotPower;
        public int robotAttackPower;
        public string weaponType;
        public List<Fleet> fleets;

        //contructor
        public Robot(string roboName, int roboHealth, int roboPower, int roboAttackPower, string roboweapon)
        {
            this.robotName = roboName;
            this.robotHealth = roboHealth;
            this.robotPower = roboPower;
            this.robotAttackPower = roboAttackPower;
            this.weaponType = roboweapon;
            fleets = new List<Fleet>();
        }
    }
}
