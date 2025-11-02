using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_upgift_2
{
    internal class ECar : Car
    {
        public bool IsElectric { get; set; }
        public ECar(string Brand, string model, string year, string typeofcar, int doors, bool IsElectric, string fuel) : base (Brand, model, year, typeofcar, doors,fuel)       
        {
            this.IsElectric = IsElectric;
        }

        public void StartEngine()
        {
            Console.WriteLine("Zaap zaap Zaap");
        }

        public void StopEngine()
        {
                Console.WriteLine("ZAAAaaaap zuppp ....");
        }

        public void AutoDrive()
        {
            Console.WriteLine("AutoPilot On");            
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("-----Vehical Info-----");
            Console.WriteLine($"Brand:          {Brand}");
            Console.WriteLine($"Model:          {model}");
            Console.WriteLine($"Year:           {year}");
            Console.WriteLine($"Doors:          {Doors}");
            Console.WriteLine($"TypeofVehical:  {TypeofCar}");
            Console.WriteLine($"Fuel:           {fuel}");
            Console.WriteLine($"IsElectric:     {IsElectric}");
            Console.WriteLine("");
        }
    }
}
