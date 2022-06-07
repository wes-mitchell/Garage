using System;

namespace garysGarage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 2.00,
                MainColor = "Blue",
                MaximumOccupancy = 4
            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 35.00,
                MainColor = "Red",
                MaximumOccupancy = 2
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 27.22,
                MainColor = "Green",
                MaximumOccupancy = 5
            };
            Ram ramThang = new Ram()
            {
                FuelCapacity = 23.75,
                MainColor = "Yellkow",
                MaximumOccupancy = 4
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
        }
    }
}
