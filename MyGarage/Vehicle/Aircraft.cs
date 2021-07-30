using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Vehicle
{
    class Aircraft : VehicleBase
    {

        public Aircraft()
        {
            Color = VehicleColorType.Silver;
        }
        public override void Refueling()
        {
            if (FuelCapacity <= 25)
            {
                Console.WriteLine("Should head back to the airport.");
            }
        }

        public void Flying()
        {
            Console.WriteLine("The aircraft in flying");
        }

        public void Landing()
        {
            Console.WriteLine("Cleared for Runway Two Zero Left.");
        }
    }
}
