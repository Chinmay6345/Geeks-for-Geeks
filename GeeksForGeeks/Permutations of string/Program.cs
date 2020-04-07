using System;
using System.Collections.Generic;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/permutations-of-a-given-string/0
/*
Given a string S. The task is to print all permutations of a given string.

Input:
The first line of input contains an integer T, denoting the number of test cases. Each test case contains a single string S in capital letter.

Output:
For each test case, print all permutations of a given string S with single space and all permutations should be in lexicographically increasing order.

Constraints:
1 ≤ T ≤ 10
1 ≤ size of string ≤ 5

Example:
Input:
2
ABC
ABSG

Output:
ABC ACB BAC BCA CAB CBA 
ABGS ABSG AGBS AGSB ASBG ASGB BAGS BASG BGAS BGSA BSAG BSGA GABS GASB GBAS GBSA GSAB GSBA SABG SAGB SBAG SBGA SGAB SGBA

Explanation:
Testcase 1: Given string ABC has permutations in 6 forms as ABC, ACB, BAC, BCA, CAB and CBA . 
*/
namespace Permutations_of_string
{
    public static class AppHelper
    {
        public static void Permute(String str,Int32 low,Int32 high)
        {
            if(low.Equals(high))
            {
                Console.WriteLine(str);
            }
            else
            {
                for(Int32 i=low;i<=high;i++)
                {
                    str = swap(str, low, i);
                    Permute(str, low + 1, high);
                    str = swap(str, low, i);
                }
            }
        }

        public static String swap(String str,Int32 i,Int32 j)
        {
            Char temp;
            Char[] chararray;
            chararray = str.ToCharArray();
            temp = chararray[i];
            chararray[i] = chararray[j];
            chararray[j] = temp;
            return new String(chararray);
        }
    }


    public class Program
    {
        private static List<String> FindPermutations(String set)
        {
            List<String> output = new List<String>();
            if (set.Length == 1)
                output.Add(set);
            else
            {
                foreach (Char c in set)
                {
                    var tail = set.Remove(set.IndexOf(c), 1);
                    foreach (var tailPerms in FindPermutations(tail))
                    {
                        output.Add(c + tailPerms);
                    }
                }
            }
            return output;
        }      

        public static void Main(string[] args)
        {
            //Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            //List<String> lstString = new List<String>();
            //for (int i = 0; i < NoOfTestCases; i++)
            //{
            //    String input = Console.ReadLine();
            //    lstString.Add(input);
            //}
            //foreach (String inputString in lstString)
            //{
            //    foreach (var t in FindPermutations(inputString).OrderBy(a => a))
            //    {
            //        Console.Write(t + " ");

            //    }
            //    Console.WriteLine();
            //}
            AppHelper.Permute("ABC", 0, "ABC".Length - 1);
            Console.ReadLine();
        }
    }
}
