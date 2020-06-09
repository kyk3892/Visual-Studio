using System;
using System.Net.NetworkInformation;

namespace Copyies
{
    class Program
    {
        static void Change(int input)
        {
            input = 20;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Change(a);
            //input의 값은 20이지만 a의 값은 return값을 받지 않았기 때문에 그대로 10이다
            Console.WriteLine("a의 값 : "+a);
        }
    }
}
