using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_array
{
    public static class AppHelper
    {
        public static void leftrotateByOne(Int32 [] arr)
        {
            for(Int32 i=0,j=arr.Length-1;i<j;i++,j--)
            {
                Int32 temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            Console.WriteLine(String.Join(",", arr.Select(g => g)));
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] arr = { 1, 2, 3, 4, 5 };
            AppHelper.leftrotateByOne(arr);
            Console.ReadLine();
        }
    }
}
