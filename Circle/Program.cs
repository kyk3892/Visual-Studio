using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("반지름을 입력하시오");
            double r = double.Parse(Console.ReadLine()); //Console.ReadLine으로 입력을 받은 문자열을 
            double area = r * r * Math.PI; //반환해주고 이 값은 double.Parse의 입력으로 들어감 이 숫자가 r로 들어감 
            Console.WriteLine("원의 면적은" + area);
        }
    }
}
