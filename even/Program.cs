using System;

namespace even
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("숫자를 입력해주세요(짝수를 입력하면 종료합니다):");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    break;
                }
            }
        }
    }
}
