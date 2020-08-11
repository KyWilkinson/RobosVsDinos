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
            }
            else if(response == "dinosaurs")
            {
                CallHerd(herd.party);
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
                Console.WriteLine(item.robotAttackPower);
                Console.WriteLine("---------------------------");
            }
        }


    }
}
