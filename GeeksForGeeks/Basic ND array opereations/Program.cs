using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ND_array_opereations
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[,] arr =  { { 1, 3, 2 },{ 6, 4, 5 } };
            
            Console.WriteLine(arr.GetUpperBound(0) + " " + arr.GetUpperBound(1));
            for(Int32 i=0;i<=arr.GetUpperBound(0);i++)
            {
                for(int j=0;j<=arr.GetUpperBound(1);j++)
                {
                    Console.WriteLine("arr["+ i + " "+ j +"]= " + arr[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
