

namespace Arv_upgift_2
{
    public class Car : Vehicle    
    {
        public string fuel {  get; set; }
        public Car(string Brand, string model, string year, string typeofcar, int doors, string fuel) : base(Brand, model, year, typeofcar, doors)
        {
            this.fuel = fuel;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("-----Vehical Info-----");
            Console.WriteLine($"Brand:      {Brand}");
            Console.WriteLine($"Model:      {model}");
            Console.WriteLine($"Year:       {year}");
            Console.WriteLine($"Doors:      {Doors}");
            Console.WriteLine($"Brand:      {TypeofCar}");
            Console.WriteLine($"Fuel:       {fuel}");
        }



      

       

       

    }
}
