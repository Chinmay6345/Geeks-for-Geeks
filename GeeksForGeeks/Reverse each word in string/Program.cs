using System;
using System.Collections.Generic;
using System.Linq;

//https://practice.geeksforgeeks.org/problems/reverse-each-word-in-a-given-string/0

namespace Reverse_each_word_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<String> lstresult = new List<String>();
            for (int j = 0; j < NoOfTestCases; j++)
            {
                String inputString = Console.ReadLine();
                lstresult.Add(String.Join(".", inputString.Split('.').Select(a => new String(a.Reverse().ToArray()))));
            }
            lstresult.ForEach(delegate(String element)
            {
                Console.WriteLine(element);
            }); 
        }
    }
}
