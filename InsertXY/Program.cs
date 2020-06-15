using System;

namespace InsertXY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[입력 예]");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("[출력 예]");
            for (int i = num1; i <= num2; i++)
            {
                Console.Write(i+" ");
            }
        }
    }
}
