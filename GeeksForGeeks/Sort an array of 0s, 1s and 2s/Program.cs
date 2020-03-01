using System;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/sort-an-array-of-0s-1s-and-2s/0 
/*
Given an array A of size N containing 0s, 1s, and 2s; you need to sort the array in ascending order.

Input:
The first line contains an integer 'T' denoting the total number of test cases. Then T testcases follow. Each testcases contains two lines of input. The first line denotes the size of the array N. The second lines contains the elements of the array A separated by spaces.

Output: 
For each testcase, print the sorted array.

Constraints:
1 <= T <= 500
1 <= N <= 106
0 <= Ai <= 2

Example:
Input :
2
5
0 2 1 2 0
3
0 1 0

Output:
0 0 1 2 2
0 0 1

Explanation:
Testcase 1: After segragating the 0s, 1s and 2s, we have 0 0 1 2 2 which shown in the output. 
*/
namespace Sort_an_array_of_0s__1s_and_2s
{
    public static class AppHelper
    {
        public static void Sort(Int32[] arr)
        {
            Console.WriteLine(String.Join(" ", arr.OrderBy(element => element).Select(g => g)));
        }
    }

    public class GFG
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                Int32 arrLength = Int32.Parse(Console.ReadLine());
                Int32[] arr = Console.ReadLine()
                             .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(a => Int32.Parse(a))
                             .ToArray<Int32>();
                AppHelper.Sort(arr);
                n = n - 1;
            }
        }
    }
}
