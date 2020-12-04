using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    public static class AppHelper
    {
        public static Int32 BinarySearch(Int32 [] arr, Int32 low,Int32 high,Int32 key)
        {
            while(low<=high)
            {
                Int32 mid = (low + high) / 2;
                if (key.Equals(arr[mid]))
                    return mid;
                else if (key < arr[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
        public static Int32 RBinarySearch(Int32 [] arr, Int32 low,Int32 high,Int32 key)
        {
            if(low<=high)
            {
                Int32 mid = (low + high) / 2;
                if (key.Equals(arr[mid]))
                    return mid;
                else if (key < arr[mid])
                    return RBinarySearch(arr,low,mid-1,key);
                else
                    return RBinarySearch(arr,mid+1,high,key);
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 1, 0, 5, 3, 6, 78, 12, 34, 65, 10, 19 };
            Array.Sort<Int32>(arr);
            Console.WriteLine(String.Join(",", arr.Select(g => g)));
            Int32 index = AppHelper.RBinarySearch(arr, 0, arr.Length - 1, 19);
            Console.WriteLine(index==-1 ? "Element not found" : "Element found at index " + index);
            Console.ReadLine();
        }
    }
}
