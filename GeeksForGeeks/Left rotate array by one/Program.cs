using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_rotate_numsay_by_one
{
    public static class AppHelper
    {
        public static Int32 [] leftrotateByOne(Int32 [] nums,Int32 n)
        {
            Int32 first = nums[0];
            for(Int32 i=1;i<n;i++)
            {
                nums[i - 1] = nums[i];
            }
            nums[n - 1] = first;
            return nums;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] nums = { 1, 2, 3, 4, 5 };
            nums = AppHelper.leftrotateByOne(nums, nums.Length);
            Console.ReadLine();
        }
    }
}
