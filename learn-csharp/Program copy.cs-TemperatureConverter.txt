using System;
class TemperatureConverter
{


    public static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature in Celsius:");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 1)
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit -32) /1.8;
            Console.WriteLine($"Temperature in celsius: {celsius}");
        }
        else if (input == 2)
        {
            Console.WriteLine("Enter temperature in celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = 1.8 * celsius + 32;
            Console.WriteLine($"Temperature in Celsius: {fahrenheit}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 1 for Celsius to Fahrenheit or 2 for Fahrenheit to Celsius.");
        }

    }
}

