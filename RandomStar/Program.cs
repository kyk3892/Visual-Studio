using System;
using System.Threading;

namespace RandomStar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Clear(); //화면 깨끗하게 만들기
            for (int i = 0; i < 20; i++)
            {
                int x = r.Next(30); //x좌표 랜덤하게 만들기
                int y = r.Next(20); //y좌표 랜덤하게 만들기
                Console.SetCursorPosition(x, y); //커서 위치 옮기기
                Console.WriteLine("*");
                Thread.Sleep(300); //0.3초 간격으로
            }
        }
    }
}
