using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Random random = new Random();
                int a = random.Next((3) + 1) * 3; //0~9 +1을 했으므로 1~10값 나온다 
                Console.WriteLine(a);
            }
        }
    }
}
