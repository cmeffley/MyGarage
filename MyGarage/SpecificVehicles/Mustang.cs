using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.SpecificVehicles
{
    class Mustang : Aircraft
    {
        public int NumberOfDownedPlanes { get; set; }
        public bool InFormation { get; set; }

        public Mustang(int planeTally)
        {
            NumberOfDownedPlanes = planeTally;
        }


        public void Mission()
        {
            if(InFormation == true)
            {
                Console.WriteLine("The P-51 Mustang is on its way to an objective");
            }
            else
            {
                Console.WriteLine("The Mustang is practicing maneuvers");
            }
        }
    }
}
