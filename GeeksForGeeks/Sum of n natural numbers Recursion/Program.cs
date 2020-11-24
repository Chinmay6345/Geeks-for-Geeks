using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_n_natural_numbers_Recursion
{
    public static class AppHelper
    {
        public static Int32 SumOfN(Int32 n)
        {
                return n == 0 ? 0 : SumOfN(n - 1) + n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppHelper.SumOfN(3));
            Console.ReadLine();
        }
    }
}
