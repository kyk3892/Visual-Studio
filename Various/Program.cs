using System;
using System.Reflection.Metadata;

namespace Various
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Patato Tomato";
            Console.WriteLine(input.ToUpper()); //대문자화
            Console.WriteLine(input.ToLower()); //소문자화
            string food,userid;
            food = "떡볶이 짬뽕 치킨 피자";
            string[] hungry = food.Split(new char[] { ' ' }); //공백을 기준으로 자른다
            foreach(var item in hungry)
            {
                Console.Write(item+"좋아합니다. ");
            }
            Console.WriteLine();
            userid = "                      kyk3892         ";
            Console.WriteLine("UserId : "+userid.Trim()); // 문자열 양 옆의 공백 제거

            string[] array = { "고구마", "감자", "토마토" };
            Console.WriteLine(string.Join("-",array)); //중간중간을 -로 연결해주겠따
        }
    }
}
