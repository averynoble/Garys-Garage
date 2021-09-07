using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();
            
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() 
            {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                ev.CurrentChargePercentage();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                ev.CurrentChargePercentage();
            }
            
            Ram ram = new Ram();
            Cessna cessna150 = new Cessna(){Name = "Cessna150"};

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                gv.CurrentTankPercentage();
            }

            MasterCraft waterCraft = new MasterCraft() {Name = "Malibu"};

            waterCraft.DockVehicle();
            Console.WriteLine($"The seating amount of the {waterCraft.Name} is {waterCraft.MaximumOccupancy}");
            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("Right");
            modelS.Stop();
            waterCraft.Turn("Left");
            cessna150.TakeOff();
        }
    }
}
