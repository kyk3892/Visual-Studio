using System;

namespace Constants
{
    class Program
    {
        //상수 const로 생성
        public const double PI = 3.141592;

        static void Main(string[] args)
        {
            //C#이 제공하는 상수, 값 변경 불가능
            //Math.PI = 3.1f;
            //방금 만든 상수, 값 변경 불가능
            //PI = 3.1f;

            int r = 10;
            Console.WriteLine("원의 둘레 : "+(2*Math.PI*r));
            Console.WriteLine("원의 넓이 : "+(PI*r*r));

            //메서드 내부에서 상수 사용
            const int value = 10;
            Console.WriteLine("상수 value 값 : "+value);

            Product pd = new Product("abc", 500);
            Console.WriteLine("product.pd의 값 : "+pd.id);
        }
    }
    class Product
    {
        private static int count = 0;
        //readonly 예시
        public readonly int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            id = ++count; //1부터 시작 전·후위 연산자
            this.name = name;
            this.price = price;
        }
    }
}
