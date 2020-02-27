using System;
using System.Collections.Generic;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/non-repeating-element/0
/*
Find the first non-repeating element in a given array A of N integers.
Note: Array consists of only positive and negative integers and not zero.

Input:
The first line of input is an integer T, denoting the number of test cases. Each test case has subsequent two lines of input. First line is an integer N, denoting size of integer array A. Second line consists of N space separated integers of the array A.

Output:
For each testcase, print the required answer. If no such element exists, then print 0

Constraints:
1 <= T <= 100;
1 <= N <= 107;
-1016 <= Ai <= 1016
{Ai !=0 }

Example:
Input:
4
5
-1 2 -1 3 2
6
9 4 9 6 7 4
3
1 1 1
2
-3 2
Output:
3
6
0
-3      
*/
namespace Non_Repeating_Element
{
    public static class AppHelper
    {
        public static void NonRepeatingElement(Int64[] arr)
        {
            Dictionary<Int64, Int64> dict = new Dictionary<Int64, Int64>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]] = 1;
                }
                else
                {
                    dict[arr[i]]++;
                }
            }
            var s = dict.Where(a => a.Value == 1).Count();
            if (s == 0)
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine(dict.Where(a => a.Value == 1).Select(a => a.Key).First());
            }
        }
    }
    public class GFG
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                Int64 arrLength = Int64.Parse(Console.ReadLine());
                Int64[] arr = Console.ReadLine()
                            .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(a => Int64.Parse(a))
                            .ToArray<Int64>();
                AppHelper.NonRepeatingElement(arr);
                n = n - 1;
            }
        }
    }
}
