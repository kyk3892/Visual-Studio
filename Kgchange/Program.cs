using System;

namespace Kgchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kg을 pound로 바꿔주는 프로그램");
            double kg = double.Parse(Console.ReadLine());
            double pound = 2.20462262 * kg;
            Console.WriteLine(kg + "kg는 " + pound + "pound 이다");
        }
    }
}
