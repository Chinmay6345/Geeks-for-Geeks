using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_rotate_by_d_positions
{
    public static class AppHelper
    {
        public static void RotateMethod2(Int32 [] arr,Int32 d)
        {
            Int32[] temp = new int[d];
            Int32 n = arr.Length;
            for(Int32 i=0;i<d;i++)
            {
                temp[i] = arr[i];
            }
            for(Int32 i=d;i<n;i++)
            {
                arr[i-d] = arr[i];
            }
            for(Int32 i=0;i<d;i++)
            {
                arr[n - d + i] = temp[i];
            }
        }

        public static void leftRotateOnce(Int32 [] arr,Int32 n)
        {
            int temp = arr[0];
            for(Int32 i=0;i<n;i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[n - 1] = temp;
        }
        public static void LeftRotateByD(Int32 [] arr,Int32 d)
        {
            for (Int32 i = 0; i < d; i++)
            {
                leftRotateOnce(arr, arr.Length);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 1, 2, 3, 4, 5 };
            Int32 d = 4;
            AppHelper.LeftRotateByD(arr, d);
            Console.ReadLine();
        }
    }
}
