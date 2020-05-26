using System;

namespace ClassName
{
     //인스턴스 변수 선언
    class User
    {
        public string name;
        public string password;
        public string address;
        public string phoneNumber;
        public DateTime regDate;
    }
    //인스턴스 변수를 선언할 때 초기화
    class Product
    {
        public string name = "default";
        public int price = 1000;
    }
    //학생 추상화
    class Student
    {
        public string id;
        public string name;
        public int grade;
        public string major;
        public DateTime birthday;
        private bool gender; //private라서 선언할때 예시로 안보임
            
        public void Study()
        {
            Console.WriteLine("Study~~~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //생성과 동시에 인스턴스 변수 초기화
            Product productA = new Product(){ name = "감자", price = 2000 };
            Product productB = new Product(){ name = "고구마", price = 3000 };

            Student std1 = new Student() { id = "0219", grade = 100 };
            Student std2 = new Student() { id = "3892", grade = 90 };
        }
    }

}
