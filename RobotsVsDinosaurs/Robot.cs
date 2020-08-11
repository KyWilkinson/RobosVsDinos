﻿using System;
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
            robotName = roboName;
            robotHealth = roboHealth;
            robotPower = roboPower;
            robotAttackPower = roboAttackPower;
            weaponType = roboweapon;
            fleets = new List<Fleet>();
        }
        
    }
}
