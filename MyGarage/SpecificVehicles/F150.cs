using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.SpecificVehicles
{
    class F150 : Car
    {
        public bool IsTowing { get; set; }
        public bool BedIsLoaded { get; set; }

        public void Construction()
        {
            if (BedIsLoaded == true)
            {
                Console.WriteLine("The F150 is at the construction site");
            }
            else if(BedIsLoaded == false)
            {
                Console.WriteLine("The truck is at not working");
            }
        }

        public void Vacation()
        {
            if(IsTowing == true)
            {
                Console.WriteLine("Towing the RV");
            }
            else if(IsTowing == false)
            {
                Console.WriteLine("No camping this weekend");
            }
        }
    }
}
