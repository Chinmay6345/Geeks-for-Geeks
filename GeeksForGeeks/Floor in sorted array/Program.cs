using System;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/floor-in-a-sorted-array/0
/*
Given a sorted array arr[] of size N without duplicates, and given a value x. Find the floor of x in given array. Floor of x is defined as the largest element K in arr[] such that K is smaller than or equal to x.

Input:
First line of input contains number of testcases T. For each testcase, first line of input contains number of elements in the array and element whose floor is to be searched. Last line of input contains array elements.

Output:
Output the index of floor of x if exists, else print -1.

Constraints:
1 ≤ T ≤ 100
1 ≤ N ≤ 107
1 ≤ arr[i] ≤ 1018
0 ≤ X ≤ arr[n-1]

Example:
Input:
3
7 0
1 2 8 10 11 12 19
7 5
1 2 8 10 11 12 19
7 10
1 2 8 10 11 12 19

Output:
-1
1
3

Explanation:
Testcase 1: No element less than 0 is found. So output is "-1".
Testcase 2: Number less than 5 is 2, whose index is 1(0-based indexing).
  
*/

namespace Floor_in_sorted_array
{
    public static class AppHelper
    {
        public static void FloorInSortedArray(Int64[] arr, Int64 element)
        {
            var k = arr.Select((val, index) => new { val, index })
                       .Where(a => a.val <= element)
                       .Select(a => a.index);
            if (!k.Any())
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(k.OrderByDescending(a => a).First());
            }
        }
    }
    public class GFG
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                Int64[] arr1 = Console.ReadLine()
                              .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(a => Convert.ToInt64(a))
                              .ToArray<Int64>();
                Int64[] arr = Console.ReadLine()
                              .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(a => Convert.ToInt64(a))
                              .ToArray<Int64>();
                AppHelper.FloorInSortedArray(arr, arr1[1]);
                n--;
            }
        }
    }
}
