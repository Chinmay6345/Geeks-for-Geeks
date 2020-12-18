using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Sort
{
    public static class AppHelper
    {
        public static void CountSort(Int32 [] a)
        {
            int x = a.Max();
            int[] b = new int[x+1];
            for(int k=0;k<a.Length;k++)
            {
                b[a[k]]++;
            }
            int i = 0, j = 0;
            while(i<x+1)
            {
                if (b[i] > 0)
                {
                    a[j++] = i;
                    b[i]--;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(String.Join(",", a.Select(g => g)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 5, 8, 12, 3, 6, 7, 10 };
            AppHelper.CountSort(a);
            Console.ReadLine();
        }
    }
}
