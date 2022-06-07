using System;

namespace garysGarage
{
  public class Cessna : Vehicle, IGasVehicle // propeller light aircraft
  {
    public double FuelCapacity { get; set; }
    public int CurrentTankPercentage  { get; set; } = 75;
    public void RefuelTank()
    {
      CurrentTankPercentage = 100;
    }
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