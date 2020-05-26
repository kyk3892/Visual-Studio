using System;
using System.Collections.Generic;

namespace ModelClass
{
    class Program
    {
        class Student
        {
            public string name;
            public int grade;
        }

        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "김윤희", grade = 1 });
            list.Add(new Student() { name = "김일이", grade = 2 });
            list.Add(new Student() { name = "김이삼", grade = 3 });
            list.Add(new Student() { name = "김삼사", grade = 4 });

            foreach(var item in list)
            {
                Console.WriteLine(item.name+" : "+item.grade);
            }
        }
    }
}
