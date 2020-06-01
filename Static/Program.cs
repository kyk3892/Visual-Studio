using System;

namespace Static
{
    //private 생성자
    class Hidden
    {
        private Hidden() { }
    }
    class Sample
    {
        public static int value;

        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //private라서 오류발생
            //Hidden hidden = new Hidden Hidden();

            //정적 생성자의 호출 시점
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value); 
            //value값만 찍으라고 했지만 문장이 나오는 이유는 Sample를 입력하는 순간 static Sample(){}이 호출됨
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample(); //초기 시점에 한 번만 호출되기 때문에 실행 안 된 것
            Console.WriteLine("세 번째 위치");

        }
    }
}
