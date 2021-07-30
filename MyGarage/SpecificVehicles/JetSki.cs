using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.SpecificVehicles
{
    class JetSki : Watercraft
    {
        public string Type { get; set; }

        public void RiderPosition(string position)
        {
            if(position == "standing")
            {
                Type = "Standing Jet Ski";
                Console.WriteLine($"{Type}");
            }
            else if(position == "sitting")
            {
                Type = "Sit down Jet Ski";
                Console.WriteLine($"{Type}");
            }
        }
    }
}
