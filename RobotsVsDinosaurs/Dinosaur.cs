using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        //member variables
        public string dinosaurName;
        public int dinosaurHealth;
        public int dinosaureEnergy;
        public int dinosaurAttackPower;
        public string dinosaurAttackType;
        List<Herd> party;

        //constructor
        public Dinosaur(string dinoName, int dinoHealth, int dinoEnergy, int dinoAttack, string attacktype)
        {
            this.dinosaurName = dinoName;
            this.dinosaurHealth = dinoHealth;
            this.dinosaureEnergy = dinoEnergy;
            this.dinosaurAttackPower = dinoAttack;
            this.dinosaurAttackType = attacktype;
            party = new List<Herd>();
        }
        //member methods
        


    }
}
