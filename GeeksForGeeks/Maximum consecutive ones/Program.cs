using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_consecutive_ones
{
    public static class AppHelper
    {
        public static Int32 MaxOnes(Int32 [] arr,Int32 n)
        {
            Int32 result = 0;
            for(Int32 i=0;i<n;i++)
            {
                Int32 count = 0;
                for(Int32 j=i;j<n;j++)
                {
                    if (arr[j] == 0)
                        count++;
                    else
                        break;
                }
                result = Math.Max(count, result);
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
