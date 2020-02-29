using System;
using System.Linq;
//29th feb
//https://practice.geeksforgeeks.org/problems/find-first-and-last-occurrence-of-x/0
/*
Given a sorted array with possibly duplicate elements. The task is to find indexes of first and last occurrences of an element X in the given array.

Input:
The first line of input contains an integer T denoting the no of test cases. Then T test cases follow. Each test case contains an integer N denoting the size of the array. Then in the next line are N space separated values of the array. The last line of each test case contains an integer X.

Output:
For each test case in a new line print two integers separated by space denoting the first and last occurrence of the element X. If the element is not present in the array print -1.

Constraints:
1 <= T <= 100
1 <= N <= 1000
1 <= A[], X <= 1018

Example:
Input:
2
9
1 3 5 5 5 5 67 123 125
5
9
1 3 5 5 5 5 7 123 125
7

Output:
2 5
6 6

Explanation:
Testcase 1: Index of first occurrence of 5 is 2 and index of last occurrence of 5 is 5. 
*/
namespace Find_first_and_last_occurrence_of_x
{
    public static class AppHelper
    {
        public static void FirstAndLastIndex(Int32[] arr, Int32 element)
        {
            Int32[] indexes = arr.Select((val, index) => new { val, index })
                                 .Where(a => a.val == element)
                                 .Select(g => g.index)
                                 .ToArray();
            if (indexes.Length == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(indexes[0] + " " + indexes.Last());
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
                Int32 arrLength = Int32.Parse(Console.ReadLine());
                Int32[] array = Console.ReadLine()
                             .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(a => Int32.Parse(a))
                             .ToArray<Int32>();
                Int32 elementToFind = Int32.Parse(Console.ReadLine());
                AppHelper.FirstAndLastIndex(array, elementToFind);
                n = n - 1;
            }
        }
    }
}
