using MyGarage.SpecificVehicles;
using MyGarage.Vehicle;
using System;
using System.Collections.Generic;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var aircraft = new Raptor();
            aircraft.FuelCapacity = 25;
            aircraft.InCombat = false;
            aircraft.PassengerCapacity = 2;

            var aircraft2 = new Mustang(5);
            aircraft2.FuelCapacity = 55;
            aircraft2.InFormation = false;
            aircraft2.PassengerCapacity = 1;


            var car = new NissanLeaf();
            car.BatteryCapacity = 30;
            car.IsCharging = true;
            car.Charge(30);
            car.PassengerCapacity = 1;
            car.Color = VehicleColorType.Blue;

            var car2 = new F150();
            car2.FuelCapacity = 25;
            car2.IsTowing = true;
            car2.PassengerCapacity = 2;
            car2.Color = VehicleColorType.Red;


            var boat = new JetSki();
            boat.Color = VehicleColorType.White;
            boat.FuelCapacity = 20;
            boat.RiderPosition("standing");
            boat.PassengerCapacity = 1;
            boat.Party = false;

            var boat2 = new SkiBoat();
            boat2.PassengerCapacity = 11;
            boat2.FuelCapacity = 85;
            boat2.WhereIsTheBoat();
            boat2.IsDocked = false;
            boat.Party = true;

            Console.WriteLine();

            var carCollections = new List<Car>() { car, car2 };
            foreach (var item in carCollections)
            {
                item.Drive();
            }

            Console.WriteLine();

            var flyCollections = new List<Aircraft>() { aircraft, aircraft2 };
            foreach (var item in flyCollections)
            {
                item.Flying();
                item.Landing();
            }

            Console.WriteLine();

            var waterCollections = new List<Watercraft>() { boat, boat2 };
            foreach (var item in waterCollections)
            {
                item.Drive();
            }

        }
    }
}
