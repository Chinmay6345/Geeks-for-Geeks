using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort_TwoLists_in_Third_List
{
    public static class AppHelper
    {       
        public static void MergeSingleArray(Int32[] arr,Int32 low,Int32 mid,Int32 high)
        {
            Int32 
                  i = low,
                  k = low,
                  j = (mid + 1);
            Int32[] b = new Int32[high];
            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                    b[k++] = arr[i++];
                else
                    b[k++] = arr[j++];
            }
            for (; i <mid; i++)
            {
                b[k++] = arr[i];
            }
            for (; j < high; j++)
            {
                b[k++] = arr[j];
            }
            Console.WriteLine(String.Join(" ", b.Select(g => g)));
        }

        public static void MergeTwoLists(Int32[] a, Int32[] b)
        {
            Int32 m = a.Length, n = b.Length, i = 0, j = 0, k = 0;
            Int32[] c = new Int32[m + n];
            while (i < m && j < n)
            {
                if (a[i] < b[j])
                {
                    c[k] = a[i];
                    i++;
                    k++;
                }
                else
                {
                    c[k] = b[j];
                    j++;
                    k++;
                }
            }
            for (; i < m; i++)
            {
                c[k] = a[i];
                //k++;
            }
            for (; j < n; j++)
            {
                c[k] = b[j];
                //k++;
            }
            Console.WriteLine(String.Join(",", c.Select(g => g)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] a = { 2, 10, 18, 20, 23 };
            Int32[] b = { 4, 9, 19, 25 };
            Int32[] c = { 2, 5, 8, 12, 3, 6, 7, 10 };
            AppHelper.MergeSingleArray(c,0,c.Length/2,c.Length-1);
            AppHelper.MergeTwoLists(a, b);
            Console.ReadLine();
        }
    }
}
