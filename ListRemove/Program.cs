using System;
using System.Collections.Generic;

namespace ListRemove
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
            
            //길이가 변하지 않으면 Length를 사용, 길이가 변하는 것은 Count
            /*for (int i=0; i<list.Count-1; i++) 
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }*/
            //위의 방법을 사용할 경우 인덱스가 한 칸씩 당겨지기 때문에 역반복문을 사용해야함

            for(int i=list.Count-1; i>=0; i--)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            foreach(var item in list)
            {
                Console.WriteLine(item.name+" : "+item.grade);
            }
        }
    }
}
