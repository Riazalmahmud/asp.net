
using System;
class  Assignment7
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter your number");
        int enterNum = int.Parse(Console.ReadLine());

        if (enterNum % 2 == 0)
        {
            Console.WriteLine("this is Event number " + enterNum);
        }
        else
        {
            Console.WriteLine("this is odd number " + enterNum);
        }
    }
}
