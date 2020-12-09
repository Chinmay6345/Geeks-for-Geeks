using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public static class AppHelper
    {
        public static Int32[] TwoSum(Int32[] nums, Int32 target)
        {
            Int32 n = nums.Length;
            for (Int32 i = 0; i < n - 1; i++)
            {
                for (Int32 j = i + 1; i < n; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new Int32[] { i, j };
                    }
                }
            }
            return new Int32[] { };
        }
        public static Int32[] TwoSumUsingMap(Int32[] nums, Int32 target)
        {
            Dictionary<Int32, Int32> Map = new Dictionary<Int32, Int32>();
            for (Int32 i = 0; i < nums.Length; i++)
            {
                Int32 compliment = target - nums[i];
                if (Map.ContainsKey(nums[i]))
                    return new Int32[] { Map[nums[i]], i };
                else
                    Map.Add(compliment, i);
            }
            return new Int32[] { };

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] nums = AppHelper.TwoSumUsingMap(new Int32[] { 2, 7, 11, 15 }, 9);
            Console.ReadLine();
        }
    }
}
