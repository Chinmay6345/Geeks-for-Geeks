using System;
using System.Collections.Generic;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/permutations-of-a-given-string/0

namespace Permutations_of_string
{
    public class Program
    {
        private static List<String> FindPermutations(String set)
        {
            List<String> output = new List<String>();
            if (set.Length == 1)
                output.Add(set);
            else
            {
                foreach (Char c in set)
                {
                    var tail = set.Remove(set.IndexOf(c), 1);
                    foreach (var tailPerms in FindPermutations(tail))
                    {
                        output.Add(c + tailPerms);
                    }
                }
            }
            return output;
        }
        public static void Main(string[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<String> lstString = new List<String>();
            for (int i = 0; i < NoOfTestCases; i++)
            {
                String input = Console.ReadLine();
                lstString.Add(input);
            }
            foreach (String inputString in lstString)
            {
                foreach (var t in FindPermutations(inputString).OrderBy(a => a))
                {
                    Console.Write(t + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
