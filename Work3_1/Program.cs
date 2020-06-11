using System;

namespace Work3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x값을 입력하시오");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("y값을 입력하시오");
            int y = int.Parse(Console.ReadLine());

            if (x > 4)
            {
                if (y > 2)
                {
                    Console.WriteLine(x * y);
                }
            }
            else
            {
                Console.WriteLine();                
            }
        }
    }
}
