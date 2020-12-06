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
        public static Int32 MissingNumberUsingSet(Int32 [] nums)
        {
            HashSet<Int32> Set = new HashSet<Int32>();
            foreach (Int32 num in nums)
                Set.Add(num);
            for(Int32 i=0;i<nums.Length+1;i++)
            {
                if (!Set.Contains(i))
                    return i;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int k = AppHelper.MissingNumberUsingSet(new int[] { 9,6,4,2,3,5,7,0,1 });
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
