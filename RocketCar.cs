using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_upgift_2
{
    internal class RocketCar : Car
    {
        Random rnd = new Random();
        int Rocket_Boosters {  get; set; }
        double Rocket_Speed { get; set; }
        bool Engineon;
        public RocketCar(string Brand, string model, string year, string typeofcar,int doors, string fuel,int Rocket_Boosters): base(Brand, model, year, typeofcar, doors, fuel)
        {
          this.Rocket_Boosters = Rocket_Boosters;
        }

        public void StartEngine()
        {
            Engineon = true;
            Console.WriteLine("BRRRRRRRRRRRRRRRRRRRRR");
        }

        public void StopEngine()
        {
            Engineon = false;
            Console.WriteLine("PHOOOOOOOOOOSSSSSSSsssss.....");
        }
        public void speed()
        {
            if (Engineon)
            {
                Rocket_Speed = rnd.Next(1000,3000);
                Console.WriteLine($"You are going {Rocket_Speed}KM/H");
            }
            else
            {
                Console.WriteLine("You need to start the Engine");
            }
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
            Console.WriteLine($"Boosters:       {Rocket_Boosters}");
            Console.WriteLine("");
        }
    }
}
