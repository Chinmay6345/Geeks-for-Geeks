using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Number
{
    public static class AppHelper
    {
        public static int MissingNumber(int[] nums)
        {
            Int32 sum = nums.Sum();
            Int32 n = nums.Length;
            Int32 s = n * (n + 1) / 2;
            return s - sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int k = AppHelper.MissingNumber(new int[] { 9,6,4,2,3,5,7,0,1 });
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
