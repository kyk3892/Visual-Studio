using System;

namespace Radiusproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("원의 반지름을 입력하시오(cm)");
            double circle = double.Parse(Console.ReadLine()); //원의 반지름
            double PI = 3.14159265; //원주율
            double circumFerence = 2 * PI * circle; //원의 둘레
            double circleArea = PI * circle * circle; //원의 넓이

            Console.WriteLine("원의 둘레 : " + circumFerence + "cm");
            Console.WriteLine("원의 넓이 : " + circleArea + "cm");

        }
    }
}
