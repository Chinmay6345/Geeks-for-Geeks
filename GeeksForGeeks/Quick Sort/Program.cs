using System;
using System.Linq;


//quick sort -Time complexity- O(nlogn) --sorts in the middle of list using recursive call.
namespace Quick_Sort
{
    public static class AppHelper
    {
        public static void Swap(ref Int32[] arr, Int32 i, Int32 k)
        {
            Int32 temp = i;
            i = k;
            k = temp;
        }
        public static Int32 Partition(Int32[] arr, Int32 low, Int32 high)
        {
            Int32 pivot = arr[low];
            Int32 i = low;
            Int32 j = high;
            Int32 temp = 0;
            do
            {
                do { i++; } while (i < arr.Length && arr[i] <= pivot);
                do { j--; } while (j >= 0 && arr[j] > pivot);
                if (i < j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            } while (i < j);
            temp = arr[low];
            arr[low] = arr[j];
            arr[j] = temp;
            return j;
        }

        public static void QuickSort(Int32[] arr, Int32 low, Int32 high)
        {
            Int32 n = arr.Length;
            Int32 j;
            if (low < high)
            {
                j = Partition(arr, low, high);
                QuickSort(arr, low, j);
                QuickSort(arr, j + 1, high);
            }
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = new Int32[] { 11, 13, 7, 12, 16, 9, 24, 5, 10, 3 };
            AppHelper.QuickSort(arr, 0, arr.Length);
            Console.ReadLine();
        }
    }
}


