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
        public List<Herd> herd;

        //costructor
        public Herd herd = new Herd()
        {
            party = new List<Herd>();
            Dinosaur velociraptor = new Dinosaur("Velociraptor", 80, 50, 7, "Claw Swipe");
            Dinosaur tRex = new Dinosaur("T-Rex", 120, 50, 17, "Tail Strike");
            Dinosaur sarcosuchus = new Dinosaur("Sarcosuchus", 100, 50, 18, "Bite");
            herd.Add(velociraptor);
            herd.Add(tRex);
            herd.Add(sarcosuchus);
        }

        //member methods
        public void PopulateHerd()
        {
            herd.Add(herd);
        }


    }
}
