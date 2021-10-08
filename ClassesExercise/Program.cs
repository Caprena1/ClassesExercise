using System;

namespace ClassesExercise
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public static void Main(string[] args)
        {
            var car1 = new Car();
            //Car car1 = new Car("Mazda", "Miata", 2014);

            car1.Make = "Mazda";
            car1.Model = "Miata";
            car1.Year = 2014;

            Console.WriteLine($"The make of the car is {car1.Make}");
            Console.WriteLine($"The model of the car is {car1.Model}");
            Console.WriteLine($"The year of the car is {car1.Year}");
        }
    }
}
