using System;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/count-occurences-of-anagrams/0

namespace Count_occurrences_of_anagram
{
    public static class AppHelper
    {
        public static void Occurrences(String input, String strcompare)
        {
            var query = from i in Enumerable.Range(0, input.Length)
                        from j in Enumerable.Range(0, input.Length - i + 1)
                        where j == strcompare.Length
                        select input.Substring(i, j);
            Int32 count = 0;
            foreach (var i in query)
            {
                if (String.Concat(i.OrderBy(c => c)).Equals(String.Concat(strcompare.OrderBy(c => c))))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    public class CFG
    {
        public static void Main(String[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (NoOfTestCases != 0)
            {
                String input = Console.ReadLine();
                String strcompare = Console.ReadLine();
                AppHelper.Occurrences(input, strcompare);
                NoOfTestCases = NoOfTestCases - 1;
            }
        }
    }
}
