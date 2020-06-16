using System;

namespace TwoStar
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<9; i++)
            {
                for(int j=0; j<9-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<2*i-1; j++)
                {
                    Console.Write("*");
                }
                for(int j=0; j<9-i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
