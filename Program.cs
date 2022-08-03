using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(80); //26.66 degrees Celsius after conversion 

            var fahrenheit = TempConverter.CelsiusToFahrenheit(35); // 95 degrees Fahrenheit after conversion 

            Console.WriteLine("After required conversion");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"celsius {celsius}");

            Console.WriteLine($"fahrenheit {fahrenheit}");

            Console.ReadLine();


        }
    }
}

