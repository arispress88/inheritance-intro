using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Red",
                CurrentChargePercentage = 50
            };
            Zero fx = new Zero()
            {
                MainColor = "Blue",
                CurrentChargePercentage = 100
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Black",
                CurrentChargePercentage = 70
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                if (ev.CurrentChargePercentage < 100)
                {
                    ev.ChargeBattery(); // This should charge the vehicle to 100%
                }
                else
                {
                    Console.WriteLine($"The {ev.MainColor} is already fully charged.");
                }
                
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            Console.WriteLine("***********************************************");

            Ram ram = new Ram ()
            {
                MainColor = "Green",
                CurrentTankPercentage = 30
            };
            Cessna cessna150 = new Cessna ()
            {
                MainColor = "Yellow",
                CurrentTankPercentage = 100
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                if (gv.CurrentTankPercentage < 100)
                {
                    gv.RefuelTank(); // This should refill the tank to 100
                }
                else
                {
                    Console.WriteLine($"The {gv.MainColor} is already full of gas.");
                }
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}