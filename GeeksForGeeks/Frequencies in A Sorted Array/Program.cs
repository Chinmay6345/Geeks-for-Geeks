using System;
using System.Collections.Generic;
using System.Linq;

namespace Frequencies_in_A_Sorted_Array
{
    public static class AppHelper
    {
        public static void Frequency(Int32[] arr, Int32 n)
        {
           Int32 freq=1,i=1;
           while(i<=n)
           {
                while(i<n && arr[i]==arr[i-1])
                {
                    freq++;
                    i++;
                }
                Console.WriteLine("element and its frequency are" + arr[i - 1] + " " + freq);
                i++;
                freq = 1;
           }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = { 10, 10, 10, 30, 40, 40, 50, 60, 60, 70 };
            AppHelper.Frequency(array, array.Length);
            Console.ReadLine();
        }
    }
}
