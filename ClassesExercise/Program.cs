using System;

namespace ClassesExercise
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            var car1 = new Car();
            

            car1.Make = "Mazda";
            car1.Model = "Miata";
            car1.Year = 2014;

            Console.WriteLine($"The make of the car is {car1.Make}");
            Console.WriteLine($"The model of the car is {car1.Model}");
            Console.WriteLine($"The year of the car is {car1.Year}");
        }
    }
}
