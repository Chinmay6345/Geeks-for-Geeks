using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public static class AppHelper
    {
        public static Int32[] TwoSum(Int32[] arr, Int32 target)
        {
            Int32 n = arr.Length;
            for (Int32 i = 0; i < n - 1; i++)
            {
                for (Int32 j = i + 1; i < n; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        return new Int32[] { i, j };
                    }
                }
            }
            return new Int32[] { };
        }
        public static Int32[] TwoSumUsingMap(Int32[] arr, Int32 target)
        {
            Dictionary<Int32, Int32> Map = new Dictionary<int, int>();
            for (Int32 i = 0; i < arr.Length; i++)
            {
                Int32 compliment = target - arr[i];
                if (Map.ContainsKey(arr[i]))
                    return new int[] { Map[arr[i]], i };
                else
                    Map.Add(compliment, i);
            }
            return new Int32[] { };

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = AppHelper.TwoSumUsingMap(new Int32[] { 2, 7, 11, 15 }, 9);
            Console.ReadLine();
        }
    }
}
