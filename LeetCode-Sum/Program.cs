using System;
using System.Collections.Generic;

namespace LeetCode_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! test 123");
            int[] element = TwoSum(new int[] { 2, 3, 4, 5 }, 7);
            Console.WriteLine("The two elements are {0},{1}", element.GetValue(0),element.GetValue(1) );
        }

        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int i = 0;
            int[] returnResult = null;
            for (i = 0; i < nums.Length; i++)
            {
                int matchtoFind = target - nums[i];
                if (dictionary.ContainsKey(matchtoFind))
                {
                    return new int[] { dictionary[matchtoFind], i };
                }
                if (!dictionary.ContainsKey(nums[i]))
                    dictionary.Add(nums[i], i);

            }
            return returnResult;
        }
    }
}
