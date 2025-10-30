
using System.Runtime.InteropServices;

namespace Arv_upgift_2
{
     public class Vehicle
    {
        public string TypeofCar { get; set; }
        public string Brand { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int Doors { get; set; }

        public Vehicle(string Brand, string model, string year, string typeofcar, int doors)
        {
            this.Brand = Brand;
            this.model = model;
            this.year = year;
            this.TypeofCar = typeofcar;
            Doors = doors;
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine sound");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("BRRrrrrr....");
        }

        public virtual void WipeWindshield()
        {
            Console.WriteLine("Swoosh Swoosh Swish Swash");
            Thread.Sleep(1000);
            Console.WriteLine("Your window is cleaned");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("-----Vehical Info-----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year:  {year}");
            Console.WriteLine($"Doors: {Doors}");
            Console.WriteLine($"Brand: {TypeofCar}");
        }
    }
}
