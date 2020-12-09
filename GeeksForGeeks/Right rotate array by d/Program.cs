using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_rotate_numsay_by_d
{
    public static class AppHelper
    {
        private static void Swap(Int32 first,Int32 second)
        {
            Int32 temp = first;
            first = second;
            second = temp;
        }
        private static void Reverse(Int32 [] nums,Int32 d,Int32 n)
        {
            Int32 low = 0;
            Int32 high = n - 1;
            while(low<high)
            {
                Swap(nums[low], nums[high]);
                low++;
                high--;
            }
        }
        public static void RightRotateByD(Int32 [] nums,Int32 d)
        {
             Int32 n = nums.Length;
             Reverse(nums, 0, n - 1);
             Reverse(nums, 0, d - 1); 
             Reverse(nums, d, n - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] nums = { 1, 2, 3, 4, 5,6,7 };
            Int32 d = 3;
            AppHelper.RightRotateByD(nums, d);
            Console.WriteLine(String.Join(" ", nums.Select(g => g)));
            Console.ReadLine();
        }
    }
}
