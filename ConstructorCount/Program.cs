using System;

namespace ConstructorCount
{
    class Program
    {
        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = counter + 1;
                this.id = counter; //본인 고유 아이디
                this.name = name;
                this.price = price;
            }
        }
        static void Main(string[] args)
        {
            Product productA = new Product("짬뽕", 9500);
            Product productB = new Product("떡볶이", 17000);
            Product productC = new Product("피자", 23000);

            Console.WriteLine(productA.id+":"+productA.name);
            Console.WriteLine(productB.id + ":" + productB.name);
            Console.WriteLine(productC.id + ":" + productC.name);
            Console.WriteLine(Product.counter+"개 생성되었습니다.");
        }
    }
}
