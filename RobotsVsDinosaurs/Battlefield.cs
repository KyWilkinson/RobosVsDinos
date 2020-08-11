﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        //Memeber Variables
        Fleet fleet = new Fleet();
        Herd herd = new Herd();
        Random random;
        //Constructor
        public Battlefield()
        {
            random = new Random();
           
        }

        //Memeber Methods

        //Main method to run the game
        //Call all methods here to run game
        public void RunGame()
        {
            Console.WriteLine("Robots Vs Dinosaurs!");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Please press enter to start");
            Console.ReadLine();
            Console.WriteLine("Choose your team robots or dinosaurs");
            string response = Console.ReadLine();
            if(response == "robots")
            {
                CallFleet(fleet.fleets);
                ShowWeaponDetails(fleet.armory);
                Console.ReadLine();
            }
            else if(response == "dinosaurs")
            {
                CallHerd(herd.party);
                Console.ReadLine();
            }

            
            
        }

        public void CallHerd(List<Dinosaur> herd)
        {
            foreach(Dinosaur item in herd)
            {
                Console.WriteLine(item.dinosaurName);
                Console.WriteLine(item.dinosaurHealth);
                Console.WriteLine(item.dinosaureEnergy);
                Console.WriteLine(item.dinosaurAttackPower);
                Console.WriteLine(item.dinosaurAttackType);
                Console.WriteLine("---------------------------");
            }

        }
        public void CallFleet(List<Robot> fleet)
        {
            foreach(Robot item in fleet)
            {
                Console.WriteLine(item.robotName);
                Console.WriteLine(item.robotHealth);
                Console.WriteLine(item.robotPower);
                Console.WriteLine(item.robotAttackPower);
                Console.WriteLine(item.weaponType);
                Console.WriteLine("---------------------------");
            }
        }
        public void BattleMechanics()
        {
            int battleDroidHealth = 100;
            int assassinDroidhealth = 80;
            int juggernautDroid = 120;
            int velociraporHealth = 100;


        }
        public void ShowWeaponDetails(List<Weapon> weapons)
        {
            foreach(Weapon item in weapons)
            {
                Console.WriteLine(item.weaponName + " " + item.attackPower);
            }
        }


    }
}
