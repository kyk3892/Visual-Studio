using System;

namespace NFound
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1, n = 1;
            int r = int.Parse(Console.ReadLine());

            while(sum < r)
            {
                n++;
                sum += n;
            }
            Console.WriteLine("n의 값 : "+(n-1));
        }
    }
}
