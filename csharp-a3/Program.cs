

using System;
class Test
{
    private static void Main(string[] args)
    {

        string? studentName = "John Doe";
        int studentAge;
        double gpa;
        Console.WriteLine("enter your name: ");
        studentName = Console.ReadLine();
        Console.WriteLine("enter your age: ");
        studentAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your gpa: ");
        gpa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Student Age: {studentAge}");
        Console.WriteLine($"Student GPA: {gpa:F2}"); // F2 formats the GPA to 2 decimal places

        // Check if the student is eligible for a scholarship
        if (gpa >= 3.5)
        {
            Console.WriteLine("Congratulations! You are eligible for a scholarship.");
        }
        else
        {
            Console.WriteLine("Keep working hard, you can achieve a scholarship in the future!");
        }
    }

}