using System;

namespace Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 연도를 입력해주십시오.");
            int year = int.Parse(Console.ReadLine());

            if (year % 12 == 0)
            {
                Console.WriteLine("원숭이띠입니다.");
            }
            if (year % 12 == 1)
            {
                Console.WriteLine("닭띠입니다.");
            }
            if (year % 12 == 2)
            {
                Console.WriteLine("개띠입니다.");
            }
            if (year % 12 == 3)
            {
                Console.WriteLine("돼지띠입니다.");
            }
            if (year % 12 == 4)
            {
                Console.WriteLine("쥐띠입니다.");
            }
            if (year % 12 == 5)
            {
                Console.WriteLine("소띠입니다.");
            }
            if (year % 12 == 6)
            {
                Console.WriteLine("범띠입니다.");
            }
            if (year % 12 == 7)
            {
                Console.WriteLine("토끼띠입니다.");
            }
            if (year % 12 == 8)
            {
                Console.WriteLine("용띠입니다.");
            }
            if (year % 12 == 9)
            {
                Console.WriteLine("뱀띠입니다.");
            }
            if (year % 12 == 10)
            {
                Console.WriteLine("말띠입니다.");
            }
            if (year % 12 == 11)
            {
                Console.WriteLine("양띠입니다.");
            }
        }
    }
}
