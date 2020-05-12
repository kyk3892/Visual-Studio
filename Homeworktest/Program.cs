using System;

namespace Homeworktest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inch를 cm로 바꿔주는 프로그램");
            double inch = double.Parse(Console.ReadLine());
            double cm = 2.54 * inch;
            Console.WriteLine(inch + "inch는 " + cm + "cm이다");
        }
    }
}
