using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Strings
{
    public class StringIntegerConversion
    {
        public static void Run()
        {
            stringToInt("149");
            intToString(150);
            Console.WriteLine();
        }

        private static void stringToInt(string input)
        {
            int result = 0;
            char[] inputCharArray = input.ToCharArray();

            for (int i = inputCharArray[0] == '-' ? 1 : 0; i < inputCharArray.Length; i++)
            {
                int digit = inputCharArray[i] - '0';
                result = result * 10 + digit;
            }

            Console.WriteLine("String to Int");
            Console.WriteLine("For input: " + input);
            Console.WriteLine(result);
        }

        private static void intToString(int input)
        {
            bool isNegative = input < 0 ? true : false;

            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Append("0" + Math.Abs(input % 10));
                input /= 10;
            }
            while (input != 0);
            if (isNegative)
            {
                sb.Append("-");
            }
            Console.WriteLine("Int to String");
            Console.WriteLine("For input: " + input);
            Console.WriteLine(reverseString(sb.ToString()));
        }

        private static string reverseString(string str)
        {
            StringBuilder sb = new StringBuilder();
            char[] strChArray = str.ToCharArray();
            for (int i = strChArray.Length - 1; i >= 0; i--)
            {
                sb.Append(strChArray[i]);
            }
            return sb.ToString();
        }

    }
}
