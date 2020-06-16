using System;

namespace Test
{
    class A
    {
        public A()
        {
            Console.WriteLine("A의 생성자");
        }
        ~A()
        {
            Console.WriteLine("A의 소멸자");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("B의 생성자");
        }
        ~B()
        {
            Console.WriteLine("B의 소멸자");
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            new B();
        }
    }
}
