using System;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/element-appearing-once/0

namespace Element_appearing_only_once
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (Int32 j = 0; j < NoOfTestCases; j++)
            {
                Int32 arrayLength = Convert.ToInt32(Console.ReadLine());
                Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray();
                var groupedArray = array.GroupBy(element => element).Select(x => new { key = x.Key, IntegerCount = x.Count() }).Where(a=>a.IntegerCount==1);
                foreach (var element in groupedArray)
                {                    
                    Console.WriteLine(element.key.ToString());                   
                }
            }           
        }
    }
}
