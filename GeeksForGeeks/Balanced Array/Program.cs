using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://practice.geeksforgeeks.org/problems/balanced-array/0
/*
Given an array of even size, task is to find minimum value that can be added to an element so that array become balanced. An array is balanced if the sum of the left half of the array elements is equal to the sum of right half.

Input:
The first line of input contains an integer T denoting the number of test cases. Each test case contains the number of elements in the array a[] as n and next line contains space separated n elements in the array a[].

Output:
Print an integer which is the required answer.

Constraints:
1<=T<=20
2<=n<=10000
1<=a[i]<=100000

Example:
Input:
2
6
1 2 1 2 1 3
2
20 10

Output:
2
10 
*/
namespace Balanced_Array
{
    public static class AppHelper
    {
        public static void Balance(Int32[] array)
        {
            Int32 sum1 = 0, sum2 = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                sum1 = sum1 + array[i];
            }
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                sum2 = sum2 + array[i];
            }
            Console.WriteLine((sum1 - sum2) > (sum2 - sum1) ? (sum1 - sum2) : (sum2 - sum1));
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
                Int32[] array = Console.ReadLine()
                             .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(a => Int32.Parse(a))
                             .ToArray<Int32>();
                AppHelper.Balance(array);
                n = n - 1;
            }
        }
    }
}
