using System;

namespace Practice
{
    class Book
    {
        public String 이름 = "PHP 프로그래밍 입문";
        public String 초판발행 = "2013년 5월 20일";
        public String 지은이 = "황재호";
        public String 펴낸이 = "김태헌";
        public String 펴낸곳 = "한빛아카데미(주)";
        public String 책임편집 = "김현용";
        public String 기획 = "김이화";
        public String 편집 = "김이화";
        public String 디자인 = "여동일";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.이름 = "김윤희";
            book.디자인 = "김윤희";
            Console.WriteLine("변경 후 book.이름 : {0}, book.디자인 : {1}",book.이름, book.디자인);
        }
    }
}
