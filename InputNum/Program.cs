using System;

namespace InputNum
{
    class Program
    {
        static int[] nums = new int[5]; //전역변수로 선언

        static void Main(string[] args)
        {
            input();    
        }

        private static void input()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
                Console.WriteLine(nums[i]);
            }
        }
    }
}
