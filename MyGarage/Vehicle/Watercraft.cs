using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Vehicle
{
    class Watercraft : VehicleBase
    {
        public bool Party { get; set; }
        public bool IsDocked { get; set; }
        public override void Refueling()
        {
            if(FuelCapacity <= 10)
            {
                Console.WriteLine("Find some where to fill up.");
            }
        }
        public void WhereIsTheBoat()
        {
            if (IsDocked == true)
            {
                Console.WriteLine("The boat is at the dock");
            }
            else if (IsDocked == false)
            {
                Console.WriteLine("The boat is on the water");
            }
        }

        public void Drive()
        {
            if(Party == true)
            {
                Console.WriteLine("Cruisin'");
            }
            else if(Party == false)
            {
                Console.WriteLine("Speed demon");
            }
        }

        public void Sinking()
        {
            if(PassengerCapacity >= 10)
            {
                Console.WriteLine("Too many people, we're going down!");
            }
        }

    }
    
}
