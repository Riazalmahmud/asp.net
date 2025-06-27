using System;
class FectorialNumber
{

    public static int Factorial(int n)
    {
        int sum = 1;
     
        for (int i = 1; i <= n; i++)
        {
            sum *= i;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            int result = Factorial(number);
            Console.WriteLine($"The factorial of {number} is {result}.");
        }
        
        Console.ReadKey();
    }
}

