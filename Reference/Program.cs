using System;
using System.Text.Encodings.Web;

namespace Reference
{
    class Program
    {
        static void Change(int input)
        {
            input = 20;
        }
        class Test
        {
            public int value = 10;
        }
        static void Change(Test input)
        {
            input.value = 20;
        }
        static void Main(string[] args)
        {
            //값 복사 예시
            int a = 10;
            Change(a);
            Console.WriteLine("a의 값 : "+a);
            
            int b = 10;
            int input = b;
            input = 20;
            Console.WriteLine("b의 값 : "+b);

            //참조 복사 예시
            Test test = new Test();
            test.value = 10;
            Change(test);
            Console.WriteLine("test.value의 값 : "+test.value);

            Test testA = new Test();
            Test testB = testA;
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine("testA.value의 값 : "+testA.value);
            //참조복사이기 때문에 testA의 value값도 같이 변경됨
        }
    }
}
