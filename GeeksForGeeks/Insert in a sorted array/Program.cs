using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_in_a_sorted_numsay
{
    public static class AppHelper
    {
        public static void InsertInSortednumsay(Int32 [] nums,Int32 element)
        {
            Array.Resize<Int32>(ref nums, nums.Length + 1);
            Int32 i = nums.Length - 1;
            nums[i] = 100;
            while(nums[i]>element)
            {
                nums[i ] = nums[i-1];
                Console.WriteLine("index and element = " +  i + " " + nums[i]);
                i--;
            }
            nums[i + 1] = element;
            Console.WriteLine(String.Join(",", nums.Select(g => g)));
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] nums = { 1, 2, 4, 5,6,7,8,9 };
            AppHelper.InsertInSortednumsay(nums,3);
            Console.ReadLine();
        }
    }
}
