using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    public static class AppHelper
    {
        public static void InsertionSort(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
            Int32 n = arr.Length;
            for (Int32 i = 1; i < n; i++)
            {
                Int32 x = arr[i];
                Int32 j = i - 1;
                Console.WriteLine("arr[j] " + arr[j]);
                while(j>-1 && arr[j]>x)
                {
                   Console.WriteLine("before arr[j] and a[j+1] = " + arr[j] + " " + arr[j+1]);
                    arr[j + 1] = arr[j];
                   Console.WriteLine("after arr[j] and a[j+1] = " + arr[j] + " " + arr[j+1]);
                    j--;
                }
                arr[j + 1] = x;
                Console.WriteLine(String.Join(" ", arr.Select(g => g)));
            }
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AppHelper.InsertionSort(new int[] { 8, 5, 7, 3, 2 });
            Console.ReadLine();
        }
    }
}
