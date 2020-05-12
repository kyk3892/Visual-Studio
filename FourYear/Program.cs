using System;

namespace FourYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            LeapYear(year);

        }
        static void LeapYear(int year) //void : 형이 없다
        {
            if (year % 4 == 0)
            {
                Console.WriteLine("윤년입니다");
            }
            else
            {
                Console.WriteLine("평년이 아닙니다");
            }
        }
    }
}
