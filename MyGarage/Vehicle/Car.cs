using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Vehicle
{
    class Car : VehicleBase
    {

        public override void Refueling()
        {
            if (FuelCapacity <= 25)
            {
                Console.WriteLine("Find a gas station, you are running low on gas.");
            }
            else if (BatteryCapacity <= 15)
            {
                Console.WriteLine("Find a charging station");
            }
        }

        public void Drive()
        {
            if (PassengerCapacity == 1)
            {
                Console.WriteLine("Drive it like you stole it!");
            }
            else if (PassengerCapacity >= 2)
            {
                Console.WriteLine("Precious cargo on board, take your time.");
            }
        }

        public void Brake()
        {
            Console.WriteLine("Hit the brakes!");
        }
    }
}
