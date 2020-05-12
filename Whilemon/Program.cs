using System;

namespace Whilemon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("입력(exit을 입력하면 종료):");
                input = Console.ReadLine();
            } while (input != "exit");
        }
    }
}
