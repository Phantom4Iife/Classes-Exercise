using System;

    namespace Classes
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Automobile myCar = new Automobile
                {
                    Brand = "Ford",
                    ModelName = "Shelby GT350",
                    ManufactureYear = 2020
                };
            
                myCar.DisplayCarDetails();
            }
        }
    }


