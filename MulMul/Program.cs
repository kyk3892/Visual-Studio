using System;

namespace MulMul
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for(int i=0; i<11; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
                sum += result;
            }
            Console.WriteLine("sum : {0}", sum);
        }
    }
}
