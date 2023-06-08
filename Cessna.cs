using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public double CurrentTankPercentage { get; set; }


        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
            Console.WriteLine($"The {MainColor} Cessna's tank is full.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zoooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Cessna dips its wing for a right turn.");
        }
    }
}