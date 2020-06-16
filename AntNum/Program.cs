using System;

namespace AntNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1";
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1)+"번째 : "+str);
                str = AntSeries(str);
            }
        }
        private static string AntSeries(string str) //입력으로 받음
        {
            char what = str[0]; //첫번째문자 가져옴
            string temp = "";
            int cnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (what == str[i])
                {
                    cnt++;
                }
                else
                {
                    temp = temp + what + cnt;
                    what = str[i];
                    cnt = 1;
                }
            }
            temp = temp + what + cnt;

            return temp;
        }
    }
}
