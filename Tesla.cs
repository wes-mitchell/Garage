using System;
namespace garysGarage
{
  public class Tesla : Vehicle, IElectricVehicle // electric car
  {
    public double BatteryKWh { get; set; }
    public int CurrentChargePercentage { get; set; } = 100;
    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }
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