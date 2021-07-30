using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Vehicle
{
    abstract class VehicleBase
    {
        public int FuelCapacity { get; set; }
        public int BatteryCapacity { get; set; }
        public VehicleColorType Color { get; set; }
        public int PassengerCapacity { get; set; }

        public abstract void Refueling();

    }
}
