using System;

namespace InsertSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input = int.Parse(Console.ReadLine()); //문자로 받은것을 숫자로 바꿔서 input에 넣기
            while (input != 0)
            {
                sum += input;
                Console.WriteLine(sum);
                
                input = int.Parse(Console.ReadLine());
            }
        }
    }
}
