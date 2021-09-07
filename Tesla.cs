using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        
        public void ChargeBattery()
        {
            BatteryKWh = 100;
        }

        public void CurrentChargePercentage()
        {
            Console.WriteLine($"The battery is currently at {BatteryKWh}");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla flashes by you! Whoosh!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {Name} drove around the sharp {direction} corner");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle came to a screaching halt!");
            Console.WriteLine();
        }
    }
}