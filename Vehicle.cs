using System;

namespace Garage
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} {Name} squeals around the {direction} corner");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle slams on the brakes to stop!");
            Console.WriteLine();
        }
    }
}