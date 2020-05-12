using System;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("가위(1) 바위(2) 보(3) 중 하나를 선택하시오");
            int game = int.Parse(Console.ReadLine());
            Random random = new Random();
            int comgame = random.Next(3) + 1;
            Console.WriteLine(comgame);
            if (game == 1)
            {
                if (comgame == 1)
                {
                    Console.WriteLine("비겼습니다");
                }
                else if (comgame == 2)
                {
                    Console.WriteLine("졌습니다");
                }
                else if (comgame == 3)
                {
                    Console.WriteLine("이겼습니다");
                }

            }
            else if (game == 2)
            {
                if (comgame == 1)
                {
                    Console.WriteLine("이겼습니다");
                }
                else if (comgame == 2)
                {
                    Console.WriteLine("비겼습니다");
                }
                else if (comgame == 3)
                {
                    Console.WriteLine("졌습니다");
                }

            }
            else if (game == 3)
            {
                if (comgame == 1)
                {
                    Console.WriteLine("졌습니다");
                }
                else if (comgame == 2)
                {
                    Console.WriteLine("이겼습니다");
                }
                else if (comgame == 3)
                {
                    Console.WriteLine("비겼습니다");
                }
            }

        }
    }
}
