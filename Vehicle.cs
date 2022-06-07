using System;

namespace garysGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public string Name { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} drives past. Vroooom!");
        }
        public void ChargeBattery()
        {
        // method definition omitted
        }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"turn {direction}.");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"comes to a stop.");
        }

    }
}