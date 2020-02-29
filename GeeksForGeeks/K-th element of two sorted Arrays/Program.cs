using System;
using System.Linq;
//https://practice.geeksforgeeks.org/problems/k-th-element-of-two-sorted-array/0
/*
Given two sorted arrays A and B of size M and N respectively and an element k. The task is to find the element that would be at the k’th position of the final sorted array.

Input:
First line consists of test cases T. First line of every test case consists of 3 integers N, M and K, denoting M number of elements in A, N number of elements in B and kth position element. Second and Third line of every test case consists of elements of A and B respectively.

Output:
Print the element at the Kth position.

Constraints:
1 <= T <= 200
1 <= N, M <= 106
1 <= Ai, Bi <= 106
1 <= K <= N+M

Example:
Input:
1
5 4 5
2 3 6 7 9
1 4 8 10

Output:
6

Explanation:
Testcase 1: Element at 5th position after merging both arrays will be 6. 
*/
namespace K_th_element_of_two_sorted_Arrays
{
    public static class AppHelper
    {
        public static void KthElementOfTwoSortedArrays(Int32[] arr_param, Int32[] A, Int32[] B)
        {
            A = A.Concat(B).ToArray<Int32>();
            Array.Sort(A);
            Int32 K = arr_param[2];
            Int32 element = A[K - 1];
            Console.WriteLine(element);
        }
    }

    public class GFG
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                Int32[] arr_param = Console.ReadLine()
                             .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(a => Int32.Parse(a))
                             .ToArray<Int32>();
                Int32[] A = Console.ReadLine()
                             .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(a => Int32.Parse(a))
                             .ToArray<Int32>();
                Int32[] B = Console.ReadLine()
                             .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(a => Int32.Parse(a))
                             .ToArray<Int32>();
                AppHelper.KthElementOfTwoSortedArrays(arr_param, A, B);
                n = n - 1;
            }
        }
    }
}
