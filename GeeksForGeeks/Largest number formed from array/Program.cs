using System;
using System.Collections.Generic;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/largest-number-formed-from-an-array/0

namespace Largest_number_formed_from_array
{
    public static class AppHelper
    {
        public static String Number(int[] array)
        {
            String[] Stringarray = Array.ConvertAll<int, String>(array, y => y.ToString()).ToArray();
            Array.Sort<String>(Stringarray, ((x, y) => (x + y).CompareTo((y + x)) > 0 ? -1 : 1));
            return String.Join("", Stringarray);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<String> lstIntg = new List<String>();
            for (int i = 0; i < NoOfTestCases; i++)
            {
                Int32 arrayLength = Convert.ToInt32(Console.ReadLine());
                Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray();
                lstIntg.Add(AppHelper.Number(array));
            }
            lstIntg.ForEach(k => { Console.WriteLine(k); });
        }
    }
}
