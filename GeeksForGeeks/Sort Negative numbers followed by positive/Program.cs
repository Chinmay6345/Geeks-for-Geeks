using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Negative_numbers_followed_by_positive
{
    public static class AppHelper
    {
        public static void SortArray(Int32[] arr)
        {
            Int32 i = 0, j = arr.Length - 1;
            while(i<j)
            {
                while (arr[i] < 0)
                    i++;
                while (arr[j] >= 0)
                    j--;
                if(i<j)
                {
                    Int32 temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            Console.WriteLine(String.Join(",", arr.Select(g => g)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { -1, 2, 3, 4, -5, 6, 7, 8, 9 };
            AppHelper.SortArray(arr);
            Console.ReadLine();
        }
    }
}
