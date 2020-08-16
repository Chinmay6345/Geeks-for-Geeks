using System;

namespace Tapping_Rain_Water
{
    public static class AppHelper
    {
        public static Int32 TappingWater(Int32 [] arr,Int32 n)
        {
            Int32 result = 0;
            for(Int32 i=1;i<n-1;i++)
            {
                Int32 lmax = arr[i];
                for(Int32 j=0;j<i;j++)
                {
                    lmax = Math.Max(lmax, arr[j]);
                }
                Int32 rmax = arr[i];
                for(Int32 k=i+1;k<n;k++)
                {
                    lmax = Math.Max(lmax, arr[k]);
                }
                result = result + Math.Min(lmax, rmax) - arr[i];
            }
            return result;
        }
        public static Int32 OTappingWater(Int32 [] arr,Int32 n)
        {
            if(arr.Length==0)
            {
                return 0;
            }
            Int32 [] lmax = new Int32[n];
            Int32 [] rmax = new Int32[n];
            Int32 result = 0;
            lmax[0] = arr[0];
            for(Int32 i=1;i<n;i++)
            {
                lmax[i] = Math.Max(lmax[i-1], arr[i]);             
            }
            for(Int32 i=n-2;i>=0;i--)
            {
                rmax[i] = Math.Max(rmax[i+1], arr[i]);  
            }
            for(Int32 i=1;i<n-1;i++)
            {
                result= result+ Math.Min(lmax[i], rmax[i])- arr[i];             
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
