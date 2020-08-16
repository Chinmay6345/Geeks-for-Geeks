using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Subarray
{
    public static class AppHelper
    {
        public static Int32 MaxSubarraySum(Int32[] arr, Int32 n)
        {
            Int32 result = 0;
            for (Int32 i = 0; i < n; i++)
            {
                Int32 current = 0;
                for (Int32 j = i; j < n; j++)
                {
                    current = current + arr[j];
                    result = Math.Max(current, result);
                }               
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
