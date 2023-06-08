using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"The {MainColor} Zero's battery is charged");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeoooooowwww!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero hugs the curve as it makes a right turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero calmly stops on a dime.");
        }
    }
}