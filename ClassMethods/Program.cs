using System;

namespace ClassMethods
{
    class Program
    {
        public int Variable = 10;
        public static int Variable2 = 10;

        static void Main(string[] args)
        {
            //클래스 메서드에서 인스턴스 변수 사용 오류
            //Console.WriteLine(Variable);    

            //클래스 메서드에서는 클래스 변수 사용으로 변경
            Console.WriteLine(Variable2);
        }
    }
}
