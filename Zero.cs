using System;

namespace garysGarage
{
    public class Zero : Vehicle, IElectricVehicle // electric motorcycle
    {
    public double BatteryKWh { get; set; }
    public int CurrentChargePercentage { get; set; } = 100;
    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Zero drives past. Zoooooom!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} Zero takes a {direction} turn.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Zero barely stops.");
    }

    }
}