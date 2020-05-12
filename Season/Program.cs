using System;

namespace Season
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("현재 몇 월입니까?");
            int month = int.Parse(Console.ReadLine());
            if (month >= 3 && month <= 5)
            {
                Console.WriteLine("봄입니다");
            }
            if (month >= 6 && month <= 8)
            {
                Console.WriteLine("여름입니다");
            }
            if (month >= 9 && month <= 11)
            {
                Console.WriteLine("가을입니다");
            }
            if (month >= 1 && month <= 2 || month == 12)
            {
                Console.WriteLine("겨울입니다");
            }
        }
    }
}
