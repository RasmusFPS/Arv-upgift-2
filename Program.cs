using System.Runtime.CompilerServices;

namespace Arv_upgift_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Bike Bike1 = new Bike("crecent", "X-SPEED", "2026", "Bike", 0, 2);
            Bike1.DisplayInfo();
            Bike1.StartEngine();
            Bike1.Wheelie();
            Console.WriteLine("");

            Car Car1 = new Car("Tesla", "S", "2017", "kombi", 4, true);
            Car1.DisplayInfo();
            Car1.StartEngine();
            Car1.AutoDrive();
            Console.WriteLine("");

            
            Car Car2 = new Car("Volvo", "V70", "1996", "Sedan", 4, false);
            Car2.DisplayInfo();
            Car2.StartEngine();
            Car2.AutoDrive();
            Console.WriteLine("");

            Truck Truck1 = new Truck("scania", "770", "2013", "Truck", 2, 250);
            Truck1.DisplayInfo();
            Truck1.StartEngine();
            Truck1.Offload();
            Console.WriteLine("");
        }
    }
}
