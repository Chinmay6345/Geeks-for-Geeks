﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibnonacci_Series
{
    public static class AppHelper
    {
        public static Int32 FibMemo(Int32 n)
        {
            Int32[] arr=new Int32[n+1];
            for(Int32 i=0;i<n;i++)
            {
                arr[i] = -1;
            }
            if (n <= 1)
            {
                arr[n] = n;
                return n;
            }
            if(arr[n-2]==-1)
            {
                arr[n - 2] = FibMemo(n - 2);
            }
            if(arr[n-1]==-1)
            {
                arr[n - 1] = FibMemo(n - 1);
            }
            arr[n]=arr[n-1]+arr[n-2];
            return arr[n-1]+arr[n-2];
        }
        public static Int32 FibRec(Int32 n)
        {
            if (n <= 1)
                return n;
            return FibRec(n - 2) + FibRec(n - 1);
        }
        public static Int32 FibIteration(Int32 n)
        {
            if (n <= 1)
            {
                return n;
            }
            int term0 = 0, term1 = 1, sum = 0;
            for(Int32 i=2;i<=n;i++)
            {
                sum = term0 + term1;
                term0 = term1;
                term1 = sum;
            }
            return sum;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(AppHelper.FibMemo(5));
            Console.ReadLine();
        }
    }
}
