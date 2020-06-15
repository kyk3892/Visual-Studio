using System;
using System.Collections.Generic;

namespace LottoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> lotto = new List<int>();
            for (int i = 1; i < 45; i++)
            {
                lotto.Add(i);
            }

            for (int i = 0; i < 6; i++)
            {
                int temp = r.Next(lotto.Count) + 1;
                Console.WriteLine(lotto[temp]);
                lotto.Remove(lotto[temp]); //리스트에서 중복제거
            }
            foreach (var item in lotto)
            {
                Console.WriteLine(item);
            }
        }
    }
}
