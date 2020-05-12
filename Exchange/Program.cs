using System;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
