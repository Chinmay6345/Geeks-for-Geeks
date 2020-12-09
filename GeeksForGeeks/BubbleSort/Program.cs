using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class AppHelper
    {
        public static void BubbleSort(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
            Int32 n = arr.Length - 1;
            for(Int32 i=0;i<n;i++)
            {
                for(Int32 j=0;j<n-i;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        Int32 temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AppHelper.BubbleSort(new int[] { 7, 1, 4, 2, 6, 0 });
            Console.ReadLine();
        }
    }
}
