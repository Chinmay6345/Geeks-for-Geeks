using System;
using System.Text;
//https://practice.geeksforgeeks.org/problems/consecutive-elements/0
/*For a given string delete the elements which are appearing more than once consecutively. All letters are of lowercase.

Input:
The first line contains an integer 'T' denoting the total number of test cases. In each test cases,  a string will be inserted.


Output:
In each seperate line the modified string should be output.


Constraints:
1<=T<=31
1<=length(string)<=100


Example:
Input:
1
aababbccd

Output:
ababcd
*/
namespace Consecutive_Elements
{
    public static class AppHelper
    {
        public static void RemoveConsecutiveElements(String input)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                    builder.Append(input[i]);
                else if (builder[builder.Length - 1] != input[i])
                    builder.Append(input[i]);
            }
            Console.WriteLine(Convert.ToString(builder));
        }
    }


    public class GFG
    {
        public static void Main(String[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (NoOfTestCases != 0)
            {
                String input = Console.ReadLine();
                AppHelper.RemoveConsecutiveElements(input);
                NoOfTestCases = NoOfTestCases - 1;
            }
        }
    }
}
