using System;

namespace Tower_of_Hanoi
{
    public static class AppHelper
    {
        public static void TowerOfHanoi(Int32 n,Char A,Char B,Char C)
        {
            if(n>0)
            {
                TowerOfHanoi(n - 1, A, C, B);
                Console.WriteLine("Move disk " + n + " from " + A + " to " +  C);
                TowerOfHanoi(n - 1, B, A, C);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AppHelper.TowerOfHanoi(3, '1', '2', '3');
            Console.ReadLine();
        }
    }
}
