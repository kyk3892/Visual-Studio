using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("1");
            }
            else if (a == 2)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("3");
                    break;


            }
        }
    }
}
