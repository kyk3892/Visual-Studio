using System;

namespace MainNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 33, 5, 9, 23, 4, 6 };
            Min(nums);
        }

        static void Min(int[] nums) //static은 static만 호출할 수 있음, 리턴값 없음
        {
            int min = nums[0];

            for(int i=1; i<nums.Length; i++)
            {
                if(nums[i] < min)
                {
                    min = nums[i];
                }
            }    
                Console.WriteLine("min : "+min);
        }
    }
}
