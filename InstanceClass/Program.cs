using System;

namespace InstanceClass
{
    class Program
    {
        class Test
        {
            public int Power(int x)
            {
                return x*x; //return은 호출한 것의 결과값
            }

            public int Add(int a, int b)
            {
                int c = a + b;
                return c;
            }
            public int Sub(int a, int b)
            {
                return a-b;
            }
            public float DivideA(float a, float b)
            {
                float c = a / b;
                return c;
            }
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
            Console.WriteLine(test.Add(3, 5));
            Console.WriteLine(test.Sub(7, 3));
            Console.WriteLine(test.DivideA(2.0f, 4.0f));            
        }
    }
}
