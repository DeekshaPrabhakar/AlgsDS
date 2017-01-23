using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Strings
{
    public class StringMath
    {
        public static string addBinary(string A, string B)
        {
            int aLength = A.Length;
            int bLength = B.Length;
            int max = aLength > bLength ? aLength : bLength;

            int carry = 0;
            StringBuilder sum = new StringBuilder();
            int add = 0;

            int firstDigit = 0;
            int secondDigit = 0;

            for (int i = 0; i < max; i++)
            {

                firstDigit = getBit(A, aLength - i - 1);
                secondDigit = getBit(B, bLength - i - 1);
                add = firstDigit + secondDigit + carry;
                sum.Append(add % 2);
                carry = add / 2;
            }

            if (carry == 1)
            {
                sum.Append("1");
            }

            char[] inputarray = sum.ToString().ToCharArray();
            Array.Reverse(inputarray);
            return new string(inputarray);
        }

        public static int getBit(String s, int index)
        {
            if (index < 0 || index >= s.Length)
                return 0;

            if (s.Substring(index, 1) == "0")
                return 0;
            else
                return 1;
        }
    }
    /*
     *  ***** Add Binary Strings *******
     *  

            Given two binary strings, return their sum (also a binary string).

            Example:

            a = "100"

            b = "11"

            Return a + b = “111”.

     */
}
