
using System;
using System.ComponentModel.DataAnnotations;
namespace makeCircle
{

    class Circle
    {
        public int radius;
        public void displayCircle()
        {
            Console.WriteLine("Enter the radius of the circle:" + Area());
        }

        public double Area()
        {
            return Math.Round(Math.PI, 4) * radius * radius;
        }
    }

    class ExcuiteCircle
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine("Math.PI :" + Math.Round(Math.PI, 4));
            Console.WriteLine("Enter the radius of the circle:");
            circle.radius = Convert.ToInt32(Console.ReadLine());
            circle.displayCircle();
            Console.WriteLine("The area of the circle is: " + circle.Area());
        }
    }


}