using System;

namespace Chicken
{
    class Program
    {
        class Chicken
        {
            private String jum;
            public Chicken(String jum) { }
            public String search()
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("치킨 집 검색 프로그램");
            Console.WriteLine("어떤 지점을 검색하시겠습니까?");
            Chicken chicken = new Chicken(jum);
            jum = Console.ReadLine();

        }
    }
}
