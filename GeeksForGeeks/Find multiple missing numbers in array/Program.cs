using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_multiple_missing_numbers_in_array
{
    public static class AppHelper
    {
        public static void MissingNumbers(int[] arr)
        {
            Int32 difference = arr[0];
            Int32 n = arr.Length;
            for(Int32 i=0;i<n;i++)
            {
                if(arr[i]-i !=difference)
                {
                    while(difference<arr[i]-i)
                    {
                        Console.WriteLine("Missing number is " + (difference + i));
                        difference += 1;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AppHelper.MissingNumbers(new int[] { 6,7,8,9,11,12,15,16,17,19});
            Console.ReadLine();
        }
    }
}
