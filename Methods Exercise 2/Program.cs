using System;

namespace Methods_Exercise_2
{
    class Program
    {
        public static double GetArea()
        {
            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());
            return Math.PI* radius *radius;

        }
    }
}
