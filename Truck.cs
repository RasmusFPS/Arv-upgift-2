
namespace Arv_upgift_2
{
    internal class Truck : Vehicle
    {
        bool enginestarted = false;

        public int weight { get; set; }
        public Truck(string Brand, string model, string year, string typeofcar, int doors, int weight) : base(Brand, model, year, typeofcar, doors)
        {
            weight = weight;
        }

        public override void StartEngine()
        {
            Console.WriteLine("BRUUMM BRUUMMM");
            enginestarted = true;
        }

        public void Offload()
        {
            if (enginestarted)
            {
                Console.WriteLine("You succsesfully offloaded your truck");
            }
            else
            {

                Console.WriteLine("you have to start the truck");
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("-----Vehical Info-----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year:  {year}");
            Console.WriteLine($"Doors: {Doors}");
            Console.WriteLine($"Brand: {TypeofCar}");
            Console.WriteLine($"Brand: {weight}");
        }

    }
}
