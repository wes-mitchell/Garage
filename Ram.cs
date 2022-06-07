using System;

namespace garysGarage
{
    public class Ram : Vehicle // Gas powered truck
    {
    public double FuelCapacity { get; set; }
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Ram drives past. rrrRRRumble!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} Ram takes a {direction} turn.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Ram comes to a excruciating stop.");
    }
    }
}