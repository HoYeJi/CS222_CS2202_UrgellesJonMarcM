using System;

namespace PentagonClass
{
    class Pentagon
    {
        public double side;

        public Pentagon()
        {
            side = 0;
        }

        public Pentagon(double sideLength)
        {
            side = sideLength;
        }

        public double GetPerimeter()
        {
            return 5 * side;
        }

        public double GetArea()
        {
            double formula = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)));
            return (formula * Math.Pow(side, 2)) / 4;
        }

        public void Display()
        {
            Console.WriteLine("Side length: " + side);
            Console.WriteLine("Perimeter: " + GetPerimeter().ToString("F3"));
            Console.WriteLine("Area: " + GetArea().ToString("F3"));
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Enter side for p1: ");
            double side1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("\nPentagon p1");
            Console.WriteLine("---------------------------");
            Pentagon p1 = new Pentagon(side1);
            p1.Display();

            Console.Write("Enter side for p2: ");
            double side2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("\nPentagon p2");
            Console.WriteLine("---------------------------");
            Pentagon p2 = new Pentagon(side2);
            p2.Display();
        }
    }
}