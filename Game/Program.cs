using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            ConsoleKeyInfo cki = Console.ReadKey();
            int j = int.Parse(Console.ReadLine());

            switch (cki.Key)
            {
                case ConsoleKey.Add:
                    Console.WriteLine(i + j);
                    break;
                case ConsoleKey.Subtract:
                    Console.WriteLine(i - j);
                    break;
                case ConsoleKey.Multiply:
                    Console.WriteLine(i * j);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }
    }
}
