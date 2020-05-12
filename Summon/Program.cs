using System;

namespace Summon
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = 0;

            for (int i = 0; i <= 100; i++)
            {
                output += i;
            }
            Console.WriteLine(output);
        }
    }
}
