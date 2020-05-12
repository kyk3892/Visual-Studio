using System;
using System.Threading;

namespace InsectWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 100)
            {
                Console.Clear(); //콘솔 화면 지우기
                Console.SetCursorPosition(x, 5); //5번째 줄에 가로로 움직임
                if (x % 3 == 0)
                {
                    Console.WriteLine(" __@");
                }
                else if (x % 3 == 1)
                {
                    Console.WriteLine("_^@");
                }
                else
                {
                    Console.WriteLine("^_@");
                }
                Thread.Sleep(100); //100밀리초 = 0.1초간 정지
                x++; //빠져나가기 위해 추가
            }
        }
    }
}
