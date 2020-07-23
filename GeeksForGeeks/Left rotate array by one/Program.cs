using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_rotate_array_by_one
{
    public static class AppHelper
    {
        public static Int32 [] leftrotateByOne(Int32 [] arr,int n)
        {
            int first = arr[0];
            for(Int32 i=1;i<n;i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[n - 1] = first;
            return arr;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 1, 2, 3, 4, 5 };
            arr = AppHelper.leftrotateByOne(arr, arr.Length);
            Console.ReadLine();
        }
    }
}
