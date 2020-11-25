using System;

namespace Taylor_series_using_Horner_rule
{
    public static class AppHelper
    {
        public static double TaylorSeries(Int32 x, Int32 n)
        {
             double s = 1;
            for (; n > 0; n--)
            {
                s = 1 + (x/n)*s;
            }
            return s;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(AppHelper.TaylorSeries(1, 10));
            Console.ReadLine();
        }
    }
}
