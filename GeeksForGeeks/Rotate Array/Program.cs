using System;
using System.Collections.Generic;
using System.Linq;
//https://practice.geeksforgeeks.org/problems/rotate-array-by-n-elements/0
namespace Rotate_Array
{
    public static class AppHelper
    {
        public static void ShiftArrayElements(Int32[] array, Int32 D)
        {
            List<Int32> lstIntg = array.ToList<Int32>();
            for (Int32 i = 0; i < D; i++)
            {
                Int32 k = lstIntg[0];
                lstIntg.RemoveAt(0);
                lstIntg.Add(k);
            }
            Console.WriteLine(String.Join(" ", lstIntg.Select(a => a)));
        }
    }

    public class GFG
    {
        public static void Main()
        {
            try
            {
                Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
                while (NoOfTestCases != 0)
                {
                    Int32[] arr = Console.ReadLine()
                                  .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(a => Convert.ToInt32(a))
                                  .ToArray<Int32>();
                    Int32[] array = Console.ReadLine()
                                   .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(a => Convert.ToInt32(a))
                                   .ToArray<Int32>();
                    AppHelper.ShiftArrayElements(array, arr[1]);
                    NoOfTestCases = NoOfTestCases - 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
Contains solutions to practice problems in C#