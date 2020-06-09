using System;

namespace Direction
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            int[,] screen = new int[80, 25]; //2차원 배열 만들기

            //커서를 화면에서 사라지게하기
            Console.CursorVisible = false;

            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        Console.SetCursorPosition(x, y); //커서 위치 옮기기
                        if(screen[x,y] == 2 || screen[x,y] ==3)
                        {
                            Console.Write("+");
                            screen[x,y] = 3;
                        }
                        else
                        {
                            Console.Write("-");
                            screen[x, y] = 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        Console.SetCursorPosition(x, y); //커서 위치 옮기기
                        if (screen[x, y] == 2 || screen[x, y] == 3)
                        {
                            Console.Write("+");
                            screen[x, y] = 3;
                        }
                        else
                        {
                            Console.Write("-");
                            screen[x, y] = 1;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        Console.SetCursorPosition(x, y); //커서 위치 옮기기
                        if (screen[x, y] == 1 || screen[x, y] == 3)
                        {
                            Console.Write("+");
                            screen[x, y] = 3;
                        }
                        else
                        {
                            Console.Write("|");
                            screen[x, y] = 2;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        Console.SetCursorPosition(x, y); //커서 위치 옮기기
                        if (screen[x, y] == 1 || screen[x, y] == 3)
                        {
                            Console.Write("+");
                            screen[x, y] = 3;
                        }
                        else
                        {
                            Console.Write("|");
                            screen[x, y] = 2;
                        }
                        break;
                    default:
                        break;
                }
                Console.SetCursorPosition(0, 0); //커서 위치 초기화
            }
        }
    }
}
