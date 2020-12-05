using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_in_a_sorted_array
{
    public static class AppHelper
    {
        public static void InsertInSortedArray(Int32 [] arr,Int32 element)
        {
            Array.Resize<Int32>(ref arr, arr.Length + 1);
            Int32 i = arr.Length - 1;
            arr[i] = 100;
            while(arr[i]>element)
            {
                arr[i ] = arr[i-1];
                Console.WriteLine("index and element = " +  i + " " + arr[i]);
                i--;
            }
            arr[i + 1] = element;
            Console.WriteLine(String.Join(",", arr.Select(g => g)));
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] arr = { 1, 2, 4, 5,6,7,8,9 };
            AppHelper.InsertInSortedArray(arr,3);
            Console.ReadLine();
        }
    }
}
