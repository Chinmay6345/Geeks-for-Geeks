using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    public static class AppHelper
    {
        static Int32[] b = new Int32[8];
        public static void MergeSingleArray(Int32[] arr, Int32 low, Int32 mid, Int32 high)
        {
            Int32
                  i = low,
                  k = low,
                  j = (mid + 1);
            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                    b[k++] = arr[i++];
                else
                    b[k++] = arr[j++];
            }
            for (; i <= mid; i++)
            {
                b[k++] = arr[i];
            }
            for (; j <= high; j++)
            {
                b[k++] = arr[j];
            }
            for (int y = low; y <= high; y++)
            {
                arr[y] = b[y];
            }
        }

        public static void MergeSort(Int32[] arr, Int32 low, Int32 mid, Int32 high)
        {
            Int32 p = 2;
            for (; p <= arr.Length; p = p * 2)
            {
                for (Int32 i = 0; ((i + p) - 1) < arr.Length; i = i + p)
                {
                    low = i;
                    high = (i + p) - 1;
                    mid = (low + high) / 2;
                    MergeSingleArray(arr, low, mid, high);
                }
            }
            if (p / 2 < arr.Length)
                MergeSingleArray(arr, 0, ((p / 2) - 1), arr.Length - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] c = { 8, 3, 7, 4, 9, 2, 6, 5,1 };
            AppHelper.MergeSort(c, 0, c.Length / 2, c.Length - 1);
            Console.ReadLine();
        }
    }
}
