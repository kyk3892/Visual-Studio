using System;

namespace Swapref
{
    class Program
    {
        private static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private static void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            
            Swap(a, b);
            Console.WriteLine("refX a의 값 : "+a); //a와 b의 값은 교환되었지만 출력값은 return값을 받은게 아니기 때문에 그대로이다
            Console.WriteLine("refX b의 값 : " + b);

            SwapRef(ref a, ref b);
            Console.WriteLine("ref a의 값 : " + a);
            Console.WriteLine("ref b의 값 : " + b); //교환법칙 성립
        }
    }
}
