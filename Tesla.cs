using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public double CurrentChargePercentage { get; set; }


        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"The {MainColor} Tesla's battery is charged.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. Shhhhhhh!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a right turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}