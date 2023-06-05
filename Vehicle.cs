using System;

namespace Garage
{
    public class Vehicle
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop.");
        }

        public virtual void Turn()
        {
            Console.WriteLine("The vehicle carefully turns right.");
        }
    }
}