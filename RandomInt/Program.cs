using System;

namespace RandomInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Console.WriteLine(ran.Next(10, 100));
            Console.WriteLine(ran.Next(10, 100));
            Console.WriteLine(ran.Next(10, 100));
            Console.WriteLine(ran.Next(10, 100));
            Console.WriteLine(ran.Next(10, 100));
        }
    }
}
