using MyGarage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.SpecificVehicles
{
    class SkiBoat : Watercraft
    {
        private string TypeOfSkier { get; set; }

        public void BoatSpeed(int speed)
        {
            if(speed >= 5 && speed <= 10)
            {
                TypeOfSkier = "WaterSki";
            }
            else if(speed >= 11 && speed <= 20)
            {
                TypeOfSkier = "KneeBoard";
            }
            else if(speed >= 21)
            {
                TypeOfSkier = "Wakeboard";
            }
        }
    

    }
}
