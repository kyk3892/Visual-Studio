using System;

namespace RandomNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int ran = new Random().Next(1, 999);
            while (true)
            {
                Console.Write("숫자를 입력해주세요: ");
                int num = int.Parse(Console.ReadLine());
                if (ran == num)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
                else
                {
                    if (num < ran)
                    {
                        Console.WriteLine(num+"보다는 큰 숫자입니다.");
                    }
                    else
                    {
                        Console.WriteLine(num+"보다는 작은 숫자입니다.");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
