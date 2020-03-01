using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://practice.geeksforgeeks.org/problems/set-bits/0
/*
Given a positive integer N, print count of set bits in it. For example, if the given number is 6(binary: 110), output should be 2 as there are two set bits in it.

Input:
The first line of input contains an integer T denoting the number of test cases. Then T test cases follow. Each testcase contains single line of input containing the N.

Output:
For each test case, in a new line, print count of set bits in it.

Constraints:
1 ≤ T ≤ 100
1 ≤ N ≤ 106

Example:
Input:
2
6
11
Output:
2
3 
     
*/
namespace Set_bits
{
    public static class AppHelper
    {
        public static void SetBits(Int32 n)
        {
            String binary = Convert.ToString(n, 2);
            Console.WriteLine(binary.Where(a => a == '1').Count());
        }
    }

    public class GFG
    {
        public static void Main(String[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (NoOfTestCases != 0)
            {
                Int32 num = Convert.ToInt32(Console.ReadLine());
                AppHelper.SetBits(num);
                NoOfTestCases = NoOfTestCases - 1;
            }
        }
    }
}
