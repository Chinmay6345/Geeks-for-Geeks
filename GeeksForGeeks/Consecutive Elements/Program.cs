using System;
using System.Text;

namespace Consecutive_Elements
{
    public static class AppHelper
    {
        public static void RemoveConsecutiveElements(String input)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                    builder.Append(input[i]);
                else if (builder[builder.Length - 1] != input[i])
                    builder.Append(input[i]);
            }
            Console.WriteLine(Convert.ToString(builder));
        }
    }


    public class GFG
    {
        public static void Main(String[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (NoOfTestCases != 0)
            {
                String input = Console.ReadLine();
                AppHelper.RemoveConsecutiveElements(input);
                NoOfTestCases = NoOfTestCases - 1;
            }
        }
    }
}
