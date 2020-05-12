using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double s = (a + b + c) / 2;
            double d = s * (s - a) * (s - b) * (s - c);
            Console.WriteLine(Math.Sqrt(d));
        }
    }
}
