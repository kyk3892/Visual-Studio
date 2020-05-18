using System;

namespace RandomDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Console.WriteLine(ran.NextDouble());
            Console.WriteLine(ran.NextDouble());
            Console.WriteLine(ran.NextDouble());
            Console.WriteLine(ran.NextDouble());
            Console.WriteLine(ran.NextDouble());
        }
    }
}
