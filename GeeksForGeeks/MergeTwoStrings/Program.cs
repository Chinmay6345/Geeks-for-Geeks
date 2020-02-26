using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://practice.geeksforgeeks.org/problems/merge-two-strings/0
/*
Given two strings S1 and S2 as input, the task is to merge them alternatively i.e. the first character of S1 then the first character of S2 and so on till the strings end.

NOTE: Add the whole string if other string is empty.

Input:
The first line of input contains an integer T denoting the number of test cases. Then T test cases follow. Each test case contains two strings S1 and S2.

Output:
For each test case, in a new line, print the merged string.

Constraints:
1 <= T <= 100
1 <= |S1|, |S2| <= 104

Example:
Input:
2
Hello Bye
abc def 
*/
namespace MergeTwoStrings
{
    public static class AppHelper
    {
        public static void MergeStrings(String[] arr)
        {
            String a = arr[0];
            String b = arr[1];
            StringBuilder builder = new StringBuilder();
            if (a.Length > b.Length)
            {
                for (Int32 i = 0; i < a.Length; i++)
                {
                    if (i < b.Length)
                    {
                        builder.Append(a[i]);
                        builder.Append(b[i]);
                    }
                    else if (!String.IsNullOrEmpty(a[i].ToString()))
                    {
                        builder.Append(a[i]);
                    }
                }
                Console.WriteLine(Convert.ToString(builder));
            }
            else
            {
                for (Int32 i = 0; i < b.Length; i++)
                {
                    if (i < a.Length)
                    {
                        builder.Append(a[i]);
                        builder.Append(b[i]);
                    }
                    else if (!String.IsNullOrEmpty(b[i].ToString()))
                    {
                        builder.Append(b[i]);
                    }
                }
                Console.WriteLine(Convert.ToString(builder));
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
                String[] array = Console.ReadLine()
                                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                AppHelper.MergeStrings(array);
                n = n - 1;
            }
        }
    }
}
