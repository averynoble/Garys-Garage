using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        
        public void ChargeBattery()
        {
            BatteryKWh = 100;
        }

        public void CurrentChargePercentage()
        {
            Console.WriteLine($"The Battery is currently at {BatteryKWh}");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero flies past you! BRRRRR!");
        }
        
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle rushed around the {direction} corner");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle rolls to a complete stop");
            Console.WriteLine();
        }
    }
}