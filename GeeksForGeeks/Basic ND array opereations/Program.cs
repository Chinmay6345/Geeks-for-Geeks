using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ND_numsay_opereations
{
    public static class AppHelper
    {
        public static void InsertAtIndex(Int32 index, Int32 element)
        {
            Int32[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            if (index <0 || index > nums.Length)
            {
                return;
            }
            Array.Resize<Int32>(ref nums, nums.Length + 1);
            for(Int32 i=nums.Length-1;i>index;i--)
            {
                nums[i] = nums[i - 1];
            }
            nums[index] = element;
        }
        public static void RemoveAtIndex()
        {
            Int32[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Int32 index = 2;
            nums[index] = -1;
            if (index <0 || index > nums.Length)
            {
                return;
            }
            for(Int32 i=index; i<nums.Length-1;i++)
            {
                nums[i] = nums[i + 1];
            }
            Array.Resize(ref nums, nums.Length - 1);
            Console.WriteLine(String.Join(",", nums.Select(g => g)));
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            AppHelper.RemoveAtIndex();
            Int32[,] nums =  { { 1, 3, 2 },{ 6, 4, 5 } };
            
            Console.WriteLine(nums.GetUpperBound(0) + " " + nums.GetUpperBound(1));
            for(Int32 i=0;i<=nums.GetUpperBound(0);i++)
            {
                for(Int32 j=0;j<=nums.GetUpperBound(1);j++)
                {
                    Console.WriteLine("nums["+ i + " "+ j +"]= " + nums[i, j]);
                }
            }
            Console.WriteLine();

            foreach(Int32 i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            String[,] nums1 = new String[3, 2] { { "a", "b"}, {"c", "d" }, { "e", "f" } };
            
            foreach(String i in nums1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for(Int32 i=0;i<nums1.GetLength(0);i++)
            {
                for(Int32 j=0;j<nums1.GetLength(1);j++)
                {
                    Console.WriteLine("nums["+ i + " "+ j +"]= " + nums1[i, j]);
                }
            }
            Int32[][] nums2 = {
                            new Int32[4]{11,12,13,14},
                            new Int32[5]{21,22,23,24,25},
                            new Int32[3]{31,32,33}
                           };
            for (Int32 i = 0; i < nums2.GetLength(0); i++)
            {
                for (Int32 j = 0; j < nums2[i].Length; j++)
                {
                    Console.WriteLine(nums2[i][j] + " " + "and i ,j = " + i + " " +j);
                }
            }
            Console.ReadLine();
        }
    }
}
