namespace Arv_upgift_2
{
    internal class Bike : Vehicle
    {
        public int wheels { get; set; }
        public Bike(string Brand, string model, string year, string typeofcar, int doors, int wheels) 
        : base(Brand, model, year, typeofcar, doors)
        {
            wheels = wheels;
        }

        public override void StartEngine()
        {
            Console.WriteLine("swoosh swiiish");
        }

        public void Wheelie()
        {
            Console.WriteLine("Your driving on one wheel");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("-----Vehical Info-----");
            Console.WriteLine($"Brand:         {Brand}");
            Console.WriteLine($"Model:         {model}");
            Console.WriteLine($"Year:          {year}");
            Console.WriteLine($"Doors:         {Doors}");
            Console.WriteLine($"TypeofVehical: {TypeofCar}");
            Console.WriteLine($"Brand:         {wheels}");
        }

    }
}
