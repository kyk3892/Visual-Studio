using System;

namespace SelfMethod
{
    class Fibonacci
    {
        public long Get(int i) //피보나치 수는 기하급수적으로 커지기때문
        {
            if (i < 0) { return 0; }
            if (i == 1) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("피보나치 수열"+i+"번째 : "+fibo.Get(i));
            }
        }
    }
}
