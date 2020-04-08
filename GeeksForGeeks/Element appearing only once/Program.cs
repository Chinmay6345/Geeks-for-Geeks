using System;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/element-appearing-once/0
/*
Given an sorted array A[i] of N positive integers having all the numbers occuring exactly twice, except for one number which will occur only once. Find the number occuring only once.

Input
The first line of input contains an integer T denoting the number of test cases. Then T test cases
follow. The first line of each test case contains a positive integer N, denoting the size of the array.
The second line of each test case contains a N positive integers, denoting the elements of the
array.


Output
Print out the singly occuring number.


Constraints
1 <= T  <= 100
0 <   N  <= 100
0 <= A[i] <= 100

Examples 

Input
2
5
1 1 2 5 5
7
2 2 5 5 20 30 30


Output
2
20 
*/
namespace Element_appearing_only_once
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (Int32 j = 0; j < NoOfTestCases; j++)
            {
                Int32 arrayLength = Convert.ToInt32(Console.ReadLine());
                Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray();
                var groupedArray = array.GroupBy(element => element).Select(x => new { key = x.Key, IntegerCount = x.Count() }).Where(a=>a.IntegerCount==1);
                foreach (var element in groupedArray)
                {                    
                    Console.WriteLine(element.key.ToString());                   
                }
            }           
        }
    }
}
