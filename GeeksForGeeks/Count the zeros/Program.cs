using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://practice.geeksforgeeks.org/problems/count-the-zeros/0
namespace Count_the_zeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Int32> listcount = new List<int>();
            int NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (Int32 j = 0; j < NoOfTestCases; j++)
            {
                Int32 arrayLength = Convert.ToInt32(Console.ReadLine());
                Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray();
                var groupedArray = array.GroupBy(ele => ele).Select(k => new { key = k.Key, count = k.Count() }).Where(a1 => a1.key == 0);
                if (groupedArray.Count() > 0)
                {
                    foreach (var element in groupedArray)
                    {
                        listcount.Add(Convert.ToInt32(element.count));
                    }
                }
                else
                    listcount.Add(0);
            }
            listcount.ForEach(delegate (int element)
            {
                Console.WriteLine(element);
            });
        }
    }
}
