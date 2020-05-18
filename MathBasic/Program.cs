using System;

namespace MathBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-52273)); //절댓값
            Console.WriteLine(Math.Ceiling(52.273)); //지정된 숫자보다 크거나 같은 최소 정수
            Console.WriteLine(Math.Floor(52.273)); //지정된 숫자보다 작거나 같은 최대 정수
            Console.WriteLine(Math.Max(52, 273)); //최댓값
            Console.WriteLine(Math.Min(52, 273)); //최솟값
            Console.WriteLine(Math.Round(52.273)); //반올림
        }
    }
}
