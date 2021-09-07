using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; } = 320.00;

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
            Console.WriteLine($"The {MainColor} Cessna blazes by you! Zoooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {Name} went around the {direction} corner really fast!");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle came to a rolling stop!");
            Console.WriteLine();
        }

        public void TakeOff()
        {
            Console.WriteLine($"The {Name} started spinning up the propeller");
        }
    }
}