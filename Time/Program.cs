using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Hour); //현재 시각을 알 수 있다

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 24)
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
