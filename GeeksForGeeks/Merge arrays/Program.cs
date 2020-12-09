using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_numsays
{
    public static class AppHelper
    {
        public static void MergeTwonumsays(Int32 [] a, Int32 [] b)
        {
            Int32 x = a.Last();
            Int32 m = a.Length;
            Int32 n = b.Length;
            Int32 i = 0, j = 0, k = 0;
            Int32[] c = new Int32[m + n];
            while(i<m && j<n)
            {
                if(a[i] < b[j])
                    c[k++] = a[i++];
                else
                    c[k++] = b[j++];
            }
            for(;i<m;i++)
            {
                c[k] = a[i];
            }
            for(;j<n;j++)
            {
                c[k] = b[j];
            }
            Console.WriteLine(String.Join(",", c.Select(g => g)));
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] a = { 3, 8, 16, 20, 25 };
            Int32[] b = { 4, 10, 12, 22, 23 };
            AppHelper.MergeTwonumsays(a,b);
            Console.ReadLine();
        }
    }
}
