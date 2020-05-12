using System;

namespace Formon
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] intArray = { 10, 20, 30, 7, 3 };

            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력 :" + intArray[i]);

                i++;
            }


        }
    }
}
