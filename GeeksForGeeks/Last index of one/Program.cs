using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//29 Feb 2020
//https://practice.geeksforgeeks.org/problems/last-index-of-1/0
/*
Given a string S consisting only '0's and '1's,  print the last index of the '1' present in it.

Input:
First line of the input contains the number of test cases T, T lines follow each containing a stream of characters.

Output:
Corresponding to every test case, output the last index of 1. If 1 is not present, print "-1" (without quotes).

Constraints:
1 <= T <= 110
1 <= |S| <= 106

Example:
Input:
2
00001
0
Output:
4
-1

Explanation:
Testcase 1: Last index of  1 in given string is 4.
Testcase 2: Since, 1 is not present, so output is -1. 
*/
namespace Last_index_of_one
{
    public class GFG
    {
        public static void Main()
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                String input = Console.ReadLine();
                int index = input.LastIndexOf("1");
                if (index > -1)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("-1");
                }
                n = n - 1;
            }
        }
    }
}
