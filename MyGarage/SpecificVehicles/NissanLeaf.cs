using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.SpecificVehicles
{
    class NissanLeaf : Car
    {
        public bool IsCharging { get; set; }

        public void Charge(int batteryLevel)
        {
            if(IsCharging == true)
            {
                BatteryCapacity = 100;
                Console.WriteLine($"{BatteryCapacity}");
            }
            else if(IsCharging == false)
            {
                Console.WriteLine($"{batteryLevel}");
            }
        }
    }
}
