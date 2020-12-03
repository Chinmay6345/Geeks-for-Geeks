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
            Console.WriteLine();

            foreach(Int32 i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            String[,] arr1 = new String[3, 2] { { "a", "b"}, {"c", "d" }, { "e", "f" } };
            
            foreach(String i in arr1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for(Int32 i=0;i<arr1.GetLength(0);i++)
            {
                for(int j=0;j<arr1.GetLength(1);j++)
                {
                    Console.WriteLine("arr["+ i + " "+ j +"]= " + arr1[i, j]);
                }
            }
            int[][] arr2 = {
                            new int[4]{11,12,13,14},
                            new int[5]{21,22,23,24,25},
                            new int[3]{31,32,33}
                           };
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.WriteLine(arr2[i][j] + " " + "and i ,j = " + i + " " +j);
                }
            }
            Console.ReadLine();
        }
    }
}
