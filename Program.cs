using System;
using System.Collections.Generic;

namespace garysGarage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();
            fxs.CurrentChargePercentage = 81;
            fx.CurrentChargePercentage = 95;
            modelS.CurrentChargePercentage = 25;
            
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Vehicle's current charge percent: {ev.CurrentChargePercentage}%");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"Vehicle's current charge percent: {ev.CurrentChargePercentage}%");
            }

            // /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();
            ram.CurrentTankPercentage = 84;
            cessna150.CurrentTankPercentage = 13;

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Vehicle's current tank percent: {gv.CurrentTankPercentage}%");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"Vehicle's current tank percent: {gv.CurrentTankPercentage}%");
            }
        }
    }
}
