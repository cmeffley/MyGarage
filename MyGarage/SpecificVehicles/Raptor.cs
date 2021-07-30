using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.SpecificVehicles
{
    class Raptor : Aircraft
    {
        public bool InCombat { get; set; }
        public void Engage()
        {
            if (InCombat == true)
            {
                Console.WriteLine("Talk to me Goose!");
            }
            else if (InCombat == false)
            {
                Console.WriteLine("Sorry Goose, but it is time to buzz the tower.");
            }
        }

        public override void Refueling()
        {
            if (FuelCapacity <= 25)
            {
                Console.WriteLine("The Stratotanker is here to refuel.");
            }
        }

    }
}
