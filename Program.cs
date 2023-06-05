using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                FuelCapacity = 100,
                MainColor = "Red",
                MaximumOccupancy = 2
            };
            Tesla modelS = new Tesla()
            {
                FuelCapacity = 48,
                MainColor = "Dark Blue",
                MaximumOccupancy = 5
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 20,
                MainColor = "Yellow",
                MaximumOccupancy = 4
            };
            Ram ram1500 = new Ram()
            {
                FuelCapacity = 30,
                MainColor = "Gold",
                MaximumOccupancy = 5
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
 
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();

            ram1500.Drive();
            ram1500.Turn();
            ram1500.Stop();

        }
    }
}