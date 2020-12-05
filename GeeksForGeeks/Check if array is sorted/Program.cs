using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_array_is_sorted
{
    public static class AppHelper
    {
        public static bool IsArraySorted(Int32[] arr)
        {
            for (Int32 i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] < arr[i - 1])
                    return false;
            }
            return true;
        }

        public static bool IsArraySortedDesc(Int32[] arr)
        {
            for (Int32 i = arr.Length - 1; i > 0; i--)
            {
                Console.WriteLine("arr[i-1] and arr[i] =" + arr[i - 1] + " " + arr[i] + " is less ?" + (arr[i - 1] < arr[i] ? true : false));
                if (arr[i - 1] < arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(AppHelper.IsArraySorted(arr));
            arr = arr.OrderByDescending(g => g).ToArray<Int32>();
            Console.WriteLine(AppHelper.IsArraySortedDesc(arr));
            Console.ReadLine();
        }
    }
}
