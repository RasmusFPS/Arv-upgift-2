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
            Bike1.WipeWindshield();
            Bike1.StopEngine();
            Console.WriteLine("");

            ECar car1 = new ECar("Tesla", "S", "2017", "kombi", 4, true, "Electricity");
            car1.DisplayInfo();
            car1.StartEngine();
            car1.AutoDrive();
            car1.WipeWindshield();
            car1.StopEngine();
            Console.WriteLine("");

            
            Car Car2 = new Car("Volvo", "V70", "1996", "Sedan", 4,"Gas");
            Car2.DisplayInfo();
            Car2.StartEngine();
            Car2.WipeWindshield();
            Car2.StopEngine();
            Console.WriteLine("");

            Truck Truck1 = new Truck("scania", "770", "2013", "Truck", 2, 250);
            Truck1.DisplayInfo();
            Truck1.StartEngine();
            Truck1.Offload();
            Truck1.WipeWindshield();
            Truck1.StopEngine();
            Console.WriteLine("");
        }
    }
}
