using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //member variables
        public string velociraptor;
        public string tRex;
        public string sarcosuchus;
        public int dinoHealth;
        public int energy;
        public int attackPower;
        public string clawAttack;
        public string tailStrike;
        public string bite;

        //constructor
        public Dinosaur(string dinoName, int veloHealth, int dinoEnergy, int dinoAttack, string attacktype1)
        {
            this.velociraptor = dinoName;
            veloHealth = 80;
            dinoEnergy = 50;
            dinoAttack = 7;
            this.clawAttack = attacktype1;
        }
        public Dinosaur(string dinoName2, int trexHealth, int dinoEnergy2, int trexAttack, string attackType)
        {
            this.tRex = dinoName2;
            trexHealth = 100;
            dinoEnergy2 = 50;
            trexAttack = 17;
            this.tailStrike = attackType;

        }
        public



    }
}
