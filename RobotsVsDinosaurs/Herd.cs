using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
        //member variabes
        public List<Dinosaur> party;

        //costructor
        public Herd()
        {
            party = new List<Dinosaur>();
            Dinosaur velociraptor = new Dinosaur("Velociraptor", 80, 50, 7, "Claw Swipe");
            Dinosaur tRex = new Dinosaur("T-Rex", 120, 50, 17, "Tail Strike");
            Dinosaur sarcosuchus = new Dinosaur("Sarcosuchus", 100, 50, 18, "Bite");
            party.Add(velociraptor);
            party.Add(tRex);
            party.Add(sarcosuchus);
        }

        //member methods
        public Herd CreateHerd()
        {
            Herd herd = new Herd();

            return herd;
            
        }

        public void PopulateHerd(Dinosaur herd)
        {
            party.Add(herd);
        }


    }
}
