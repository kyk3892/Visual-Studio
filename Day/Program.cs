using System;

namespace Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("날수를 입력해주십시오");
            int leap = int.Parse(Console.ReadLine());
            int week = leap / 7;
            int day = leap % 7;
            Console.WriteLine("{0}주, {1}일", week, day); //코딩에서 처음숫자는 0이다.
        }
    }
}
