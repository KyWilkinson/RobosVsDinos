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

        //constructor
        public Dinosaur(string dinoName, int dinoHealth, int dinoEnergy, int dinoAttack, string attacktype)
        {
            dinosaurName = dinoName;
            dinosaurHealth = dinoHealth;
            dinosaureEnergy = dinoEnergy;
            dinosaurAttackPower = dinoAttack;
            dinosaurAttackType = attacktype;
        }
        //member methods

        public void Attack(Robot robot)
        {
            robot.robotHealth -= dinosaurAttackPower;
        }

        //How to get Robot attack dinosaur an vice versa
        //^^ Loops are key
        //how to select a target
        //^^ use s switch which i dont really have a clue watch the vids again
        //how to get targets health to drop by the proper amount
        //^^ is going to be a loop solution but what kind
        //how to break this problem down even more



    }
}
