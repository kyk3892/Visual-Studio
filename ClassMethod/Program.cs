using System;

namespace ClassMethod
{
    class Program
    {
        class MyMath
        {
            public static int Abs(int input) //절댓값 함수 만들기
            {
                if(input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }
        }
        static void Main(string[] args) //메인함수는 정적 메소드이다.
        {
            Console.WriteLine(MyMath.Abs(-52)); //클래스를 생성하지 않고 바로 호출할 수 있는 이유는 static이기 때문
            Console.WriteLine(MyMath.Abs(-273));
        }
    }
}
