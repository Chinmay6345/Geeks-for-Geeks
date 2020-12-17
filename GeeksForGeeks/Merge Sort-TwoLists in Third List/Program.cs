using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort_TwoLists_in_Third_List
{
    public static class AppHelper
    {
        public static void MergeTwoLists(Int32 [] a, Int32 [] b)
        {
            Int32 m = a.Length, n = b.Length, i = 0, j = 0, k = 0;
            Int32[] c = new Int32[m + n];
            while(i<m && j<n)
            {
                if(a[i]<b[j])
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
            for(;i<m;i++)
            {
                c[k] = a[i];
                //k++;
            }
            for(;j<n;j++)
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
            Int32 [] a = { 2, 10, 18, 20, 23 };
            Int32[] b = { 4, 9, 19, 25 };
            AppHelper.MergeTwoLists(a, b);
            Console.ReadLine();
        }
    }
}
