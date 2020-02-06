using System;
using System.Linq;
//https://practice.geeksforgeeks.org/problems/missing-number-in-array/0
namespace Missing_number_in_an_array
{
    public static class AppHelper
    {
        public static void Missing(Int32[] arr)
        {
            Int32 m = arr.Length + 1;
            Int32 total = (m * (m + 1)) / 2;
            Int32 sum = arr.Sum();
            Int32 missing = total - sum;
            Console.WriteLine(missing);
        }
    }
    public class Progam
    {
        public static void Main()
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                Int32 arraylength = Convert.ToInt32(Console.ReadLine());
                Int32[] arr = Console.ReadLine()
                              .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(a => Convert.ToInt32(a))
                              .ToArray<Int32>();
                AppHelper.Missing(arr);

                n = n - 1;
            }
        }
    }
}

