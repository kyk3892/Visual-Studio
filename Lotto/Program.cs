using System;
using System.ComponentModel.DataAnnotations;

namespace Lotto
{
    class Program
    {
        static int[] num = new int[6];

        static void Main(string[] args)
        {
            Random r = new Random();

            for (int i = 0; i < 6; i++)
            {
                num[i] = r.Next(45) + 1;
                bool c = CheckNum(num[i], i); //인덱스 값도 같이 주기
                
                if(c == true)
                {
                    Console.WriteLine(num[i]);
                }
                else
                {
                    i--; //다시 계산해야되므로
                }
            }
        }
        private static bool CheckNum(int v, int j)
        {
            for (int i = 0; i < j; i++)
            {
                if(v == num[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
