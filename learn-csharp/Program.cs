using System;
class Test
{
    public static void Main(string[] args)
    {
        // double fahrenheit, calicos;
        // Console.Write("Enter the temperature in Celsius: ");
        // fahrenheit = Convert.ToDouble(Console.ReadLine());
        // calicos = (fahrenheit - 32) % 1.8;
        // Console.WriteLine("The temperature in Fahrenheit is: " + calicos.ToString("F2"));

        double fahrenheit, celsius;
        Console.Write("Enter the temperature in Celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());
        fahrenheit = (1.8 * celsius) + 32;
        Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit.ToString("F2"));
    }
}

