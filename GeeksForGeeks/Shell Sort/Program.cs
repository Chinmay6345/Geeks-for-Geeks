using System;
using System.Linq;

namespace Shell_Sort
{
    public static class AppHelper
    {
        public static void ShellSort(Int32[] arr, Int32 n)
        {
            Console.WriteLine("Before sorting " + String.Join(",", arr.Select(g => g)));
            for (int gap=n/2; gap / 2 >= 1; gap = gap / 2)
            {
                for (Int32 j = gap; j < n; j++)
                {
                    Int32 temp = arr[j];
                    Int32 i = j - gap;
                    while(i>=0 && arr[i]>temp)
                    {
                        arr[i + gap] = arr[i];
                        i = i - gap;
                    }
                    arr[i + gap] = temp;
                }
            }
            Console.WriteLine("After  sorting " + String.Join(",", arr.Select(g => g)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 11, 13, 7, 12, 16, 9, 24, 5, 10, 3 };
            AppHelper.ShellSort(arr, arr.Length);
            Console.ReadLine();
        }
    }
}
