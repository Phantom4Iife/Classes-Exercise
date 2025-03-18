using System;

namespace Classes
{
    public class Automobile
    {
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public int ManufactureYear { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Automobile myCar = new Automobile();
            
            myCar.Brand = "Mustang";
            myCar.ModelName = "Shelby GT350";
            myCar.ManufactureYear = 2020;;
            
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make: {myCar.Brand}");
            Console.WriteLine($"Model: {myCar.ModelName}");
            Console.WriteLine($"Year: {myCar.ManufactureYear}");
        }
    }
}

