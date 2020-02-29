using System;
using System.Collections.Generic;
using System.Linq;
//https://practice.geeksforgeeks.org/problems/count-the-zeros/0

/*
Given an array of size N consisting of only 0's and 1's ,which is sorted in such a manner that all the 1's are placed first and then they are followed by all the 0's. You have to find  the count of all the 0's.
 

Input:
The first line of input contains an integer T denoting the number of test cases. Then T test cases follow. 
The first line of each test case contains an integer N, where N is the size of the array A[ ].
The second line of each test case contains N space separated integers of all 1's follwed by all the 0's, denoting elements of the array A[ ].


Output:
Print out the number of 0's in the array. 
 

Constraints:
1 <= T <= 100
1 <= N <= 30
0 <= A[i] <= 1
 

Example :

Input:
3
12
1 1 1 1 1 1 1 1 1 0 0 0 
5
0 0 0 0 0
6
1 1 1 1 1 1


Output:
3
5
0
 

Expected Complexity:

O(logN) 
*/
namespace Count_the_zeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Int32> listcount = new List<int>();
            int NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (Int32 j = 0; j < NoOfTestCases; j++)
            {
                Int32 arrayLength = Convert.ToInt32(Console.ReadLine());
                Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray();
                var groupedArray = array.GroupBy(ele => ele).Select(k => new { key = k.Key, count = k.Count() }).Where(a1 => a1.key == 0);
                if (groupedArray.Count() > 0)
                {
                    foreach (var element in groupedArray)
                    {
                        listcount.Add(Convert.ToInt32(element.count));
                    }
                }
                else
                    listcount.Add(0);
            }
            listcount.ForEach(delegate (int element)
            {
                Console.WriteLine(element);
            });
        }
    }
}
