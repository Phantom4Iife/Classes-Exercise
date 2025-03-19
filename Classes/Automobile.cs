using System;

namespace Classes
{
    public class Automobile
    {
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public int ManufactureYear { get; set; }
        
        public void DisplayCarDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make: {Brand}");
            Console.WriteLine($"Model: {ModelName}");
            Console.WriteLine($"Year: {ManufactureYear}");
        }
    }
}