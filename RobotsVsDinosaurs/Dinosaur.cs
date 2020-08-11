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
        public List<Herd> party;

        //constructor
        public Dinosaur(string dinoName, int dinoHealth, int dinoEnergy, int dinoAttack, string attacktype)
        {
            dinosaurName = dinoName;
            dinosaurHealth = dinoHealth;
            dinosaureEnergy = dinoEnergy;
            dinosaurAttackPower = dinoAttack;
            dinosaurAttackType = attacktype;
            party = new List<Herd>();
        }
        //member methods
        


    }
}
