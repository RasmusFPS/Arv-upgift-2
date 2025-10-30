

namespace Arv_upgift_2
{
    public class Car : Vehicle
    {
        public bool IsElectric { get; set; }
        public Car(string Brand, string model, string year, string typeofcar, int doors, bool IsElectric) : base(Brand, model, year, typeofcar, doors)
        {
            this.IsElectric = IsElectric;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("-----Vehical Info-----");
            Console.WriteLine($"Brand:      {Brand}");
            Console.WriteLine($"Model:      {model}");
            Console.WriteLine($"Year:       {year}");
            Console.WriteLine($"Doors:      {Doors}");
            Console.WriteLine($"Brand:      {TypeofCar}");
            Console.WriteLine($"IsElectric: {IsElectric}");
        }

        public override void StartEngine()
        {
            if (this.IsElectric)
            {
                Console.WriteLine("Zaap zaap Zaap");
            }
            else
            {
                Console.WriteLine("Vroom Vroom Vrrrr");
            }
        }

        public void AutoDrive()
        {
            if (this.IsElectric)
            {
                Console.WriteLine("AutoPilot On");
            }
            else
            {
                Console.WriteLine("Cant turn on AutoPilot on this vehical");
            }
        }

    }
}
