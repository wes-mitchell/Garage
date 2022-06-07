using System;
namespace garysGarage
{
  public class Tesla : Vehicle
  {
    public double BatteryKWh { get; set; }
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Tesla drives past. Zooom!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} Tesla takes a {direction} turn.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Tesla comes to a roaring stop.");
    }
  }
}