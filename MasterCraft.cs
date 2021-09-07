using System;

namespace Garage
{
    public class MasterCraft : Vehicle, IWaterVehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; } = 34.00;
        public double WaterAmount { get; set; } = 12.94;
        
        public MasterCraft()
        {
            MaximumOccupancy = 7;
        }

        public void RefuelTank()
        {
            FuelCapacity++;
        }

        public void AmountOfWater()
        {
            Console.WriteLine($"There is still {WaterAmount} of water in the boat!");
        }
        
        public void CurrentTankPercentage()
        {
            Console.WriteLine($"The tank is currently at {FuelCapacity}");
        }

        public void DockVehicle()
        {
            Console.WriteLine($"You need to dock the {Name}");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {Name} turned {direction} around the bend");
        }
    }
}