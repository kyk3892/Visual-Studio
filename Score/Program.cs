using System;

namespace Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학년을 입력하세요 : ");
            int level = int.Parse(Console.ReadLine());

            switch (level)
            {
                case 1:
                    Console.WriteLine("수강해야 하는 전공 학점 : 12학점");
                    break;
                case 2:
                    Console.WriteLine("수강해야 하는 전공 학점 : 18학점");
                    break;
                case 3:
                    Console.WriteLine("수강해야 하는 전공 학점 : 10학점");
                    break;
                case 4:
                    Console.WriteLine("수강해야 하는 전공 학점 : 18학점");
                    break;
                default:
                    Console.WriteLine("1~4학년 중 입력해주십시오.");
                    break;
            }
        }
    }
}
