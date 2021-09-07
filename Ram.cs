using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; } = 17.00;
        
        public void RefuelTank()
        {
            FuelCapacity++;
        }

        public void CurrentTankPercentage()
        {
            Console.WriteLine($"The {Name} is at {FuelCapacity}");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram zips by you! RRrrrruuuummmbbbllleee!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {Name} drifted around the {direction} corner");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle comes to a squeaky stop!");
            Console.WriteLine();
        }
    }
}