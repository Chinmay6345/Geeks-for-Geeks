using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_numsay_is_sorted
{
    public static class AppHelper
    {
        public static bool IsnumsaySorted(Int32[] nums)
        {
            for (Int32 i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] < nums[i - 1])
                    return false;
            }
            return true;
        }

        public static bool IsnumsaySortedDesc(Int32[] nums)
        {
            for (Int32 i = nums.Length - 1; i > 0; i--)
            {
                Console.WriteLine("nums[i-1] and nums[i] =" + nums[i - 1] + " " + nums[i] + " is less ?" + (nums[i - 1] < nums[i] ? true : false));
                if (nums[i - 1] < nums[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(AppHelper.IsnumsaySorted(nums));
            nums = nums.OrderByDescending(g => g).ToArray<Int32>();
            Console.WriteLine(AppHelper.IsnumsaySortedDesc(nums));
            Console.ReadLine();
        }
    }
}
