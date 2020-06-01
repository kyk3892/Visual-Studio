using System;

namespace Constructor
{
    class Product
    {
        public string name;
        public int price;

        //생성자
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product pd = new Product("hat", 3000);
        }
    }
}
