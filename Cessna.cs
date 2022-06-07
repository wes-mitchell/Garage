using System;

namespace garysGarage
{
  public class Cessna : Vehicle
  {
    public double FuelCapacity { get; set; }
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Cessna drives past. Dang ol boom man!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} Cessna takes a {direction} turn.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Cessna comes to a nail biting stop.");
    }
  }
}