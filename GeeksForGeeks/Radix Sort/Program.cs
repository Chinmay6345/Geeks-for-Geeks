using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_Sort
{
    public static class AppHelper
    {
        public static void radixsort(int[] arr, int n)
        {
            // Find the maximum number to know number of digits 
            int m = arr.Max() ;

            // Do counting sort for every digit. Note that 
            // instead of passing digit number, exp is passed. 
            // exp is 10^i where i is current digit number 
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }
        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n]; // output array 
            int i;
            int[] count = new int[10];

            // initializing all elements of count to 0 
            for (i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[] 
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains 
            // actual 
            //  position of this digit in output[] 
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array 
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now 
            // contains sorted numbers according to current 
            // digit 
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            int n = arr.Length;

            // Function Call 
            AppHelper.radixsort(arr, n);
             Console.ReadLine();
        }
    }
}
