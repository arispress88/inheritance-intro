using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            //method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls past you. RRrrrrrummbbble!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles to a halt.");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Ram takes a massive right turn.");
        }
    }
}