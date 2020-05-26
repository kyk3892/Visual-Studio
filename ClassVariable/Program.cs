using System;

namespace ClassVariable
{
    class Program
    {
        class MyMath
        {
            public static double PI = 3.141592; //static을 쓰면 인스턴스를 따로 안만들어도됨
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.PI);
        }
    }
}
