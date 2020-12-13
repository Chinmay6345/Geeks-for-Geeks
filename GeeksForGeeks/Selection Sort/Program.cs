using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    public static class AppHelper
    {
        public static void Swap(ref Int32[] arr, Int32 i, Int32 k)
        {
            Int32 temp = arr[i];
            arr[i] = arr[k];
            arr[k] = temp;
        }

        public static void SelectionSort(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
            Int32 n = arr.Length;
            Int32 i = 0, j, k;
            for (i = 0; i < n - 1; i++)
            {
                for (j = k = i; j < n; j++)
                {
                    if (arr[j] < arr[k])
                    {
                        k = j;
                    }
                }
                Int32 temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
            }
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
        }
        public static void SelectionSortDesc(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
            Int32 n = arr.Length;
            Int32 i = 0, j, k;
            for (i = 0; i < n - 1; i++)
            {
                for (j = k = i; j < n; j++)
                {
                    if (arr[j] > arr[k])
                    {
                        k = j;
                    }
                }
                Int32 temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
            }
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AppHelper.SelectionSort(new int[] { 8, 6, 3, 2, 5, 4 });
            Console.ReadLine();
        }
    }
}
