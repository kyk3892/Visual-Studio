using System;
using System.Globalization;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            int min=0, max=0;
            for(int i=0; i<5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
                min = nums[0];
                max = nums[0];
            }
            for(int i=0; i<5; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("가장 큰 수: " + max);
            Console.WriteLine("가장 작은 수: " + min);

        }
    }
}
