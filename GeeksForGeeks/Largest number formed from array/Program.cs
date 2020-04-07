using System;
using System.Collections.Generic;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/largest-number-formed-from-an-array/0
/*
Given a list of non negative integers, arrange them in such a manner that they form the largest number possible.The result is going to be very large, hence return the result in the form of a string.

Input:
The first line of input consists number of the test cases. The description of T test cases is as follows:
The first line of each test case contains the size of the array, and the second line has the elements of the array.

Output:
In each separate line print the largest number formed by arranging the elements of the array in the form of a string.

Constraints:
1 ≤ T ≤ 100
1 ≤ N ≤ 102
0 ≤ A[i] ≤ 103

Example:
Input:
2
5
3 30 34 5 9
4
54 546 548 60

Output:
9534330
6054854654 
*/
namespace Largest_number_formed_from_array
{
    public static class AppHelper
    {
        public static String Number(int[] array)
        {
            String[] Stringarray = Array.ConvertAll<int, String>(array, y => y.ToString()).ToArray();
            Array.Sort<String>(Stringarray, ((x, y) => (x + y).CompareTo((y + x)) > 0 ? -1 : 1));
            return String.Join("", Stringarray);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<String> lstIntg = new List<String>();
            for (int i = 0; i < NoOfTestCases; i++)
            {
                Int32 arrayLength = Convert.ToInt32(Console.ReadLine());
                Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray();
                lstIntg.Add(AppHelper.Number(array));
            }
            lstIntg.ForEach(k => { Console.WriteLine(k); });
        }
    }
}
