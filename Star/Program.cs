using System;

namespace Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0; //콘솔에서 커서의 좌표

            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    default:
                        break;

                }
                Console.SetCursorPosition(x, y); //x,y위치에 커서 위치하는 방법
                Console.WriteLine("*");
            }

        }
    }
}
