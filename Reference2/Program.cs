using System;

namespace Reference2
{
    class Test
    {
        public int value = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test testA = new Test();
            Test testB = testA;
            testA.value = 10;
            testB.value = 20;
            //참조복사이기 때문에 testA의 value값도 같이 변경됨
            Console.WriteLine("testA.value : "+testA.value);

        }
    }
}
