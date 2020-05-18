using System;
using System.Collections.Generic;

namespace ListAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(52); //리스트 요소 추가
            list.Add(273);
            list.Add(32);
            list.Add(64);

            list.Remove(273); //리스트 요소 제거
            foreach(var item in list)
            {
                Console.WriteLine("Count: "+list.Count+"\titem: "+item);
            }

        }
    }
}
