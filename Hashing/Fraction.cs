using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class Fraction
    {
        public static string fractionToDecimal(int A, int B)
        {
            StringBuilder sb = new StringBuilder();

            if (B == 0)
            {
                return "NaN";
            }

            if (A == 0)
            {
                return "0";
            }

            bool isNegative = false;
            if ((A < 0) || (B < 0))
            {
                if ((A < 0 && B > 0) || (A > 0 && B < 0))
                {
                    isNegative = true;
                }
            }

            long num = A;
            long den = B;

            num = Math.Abs(num);
            den = Math.Abs(den);

            long integerPart = num / den;
            sb.Append(integerPart.ToString());
            long remainder = (num % den) * 10;
            if (remainder == 0)
            {
                if (isNegative)
                {
                    return "-" + remainder.ToString();
                }
                else
                {
                    return sb.ToString();
                }
            }

            sb.Append(".");
            Dictionary<long, int> remainderMap =  new Dictionary<long, int>();
            while (remainder != 0)
            {
                if (remainderMap.ContainsKey(remainder))
                {
                    int pos = int.Parse(remainderMap[remainder].ToString());
                    string res = sb.ToString();
                    String part1 = res.Substring(0, pos);
                    String part2 = res.Substring(pos);
                    sb = new StringBuilder();
                    sb.Append(part1 + "(" + part2 + ")");

                    if (isNegative)
                    {
                        return "-" + sb.ToString();
                    }
                    else
                    {
                        return sb.ToString();
                    }
                }

                sb.Append((remainder / den).ToString());
                remainderMap.Add(remainder, sb.Length - 1);
                remainder = (remainder % den) * 10;
            }
            if (isNegative)
            {
                return "-" + sb.ToString();
            }
            else
            {
                return sb.ToString();
            }
        }

        /*
         * ************** Fraction ******************
         * 

            Given two integers representing the numerator and denominator of a fraction, return the fraction in string format.

            If the fractional part is repeating, enclose the repeating part in parentheses.

            Example :

            Given numerator = 1, denominator = 2, return "0.5"
            Given numerator = 2, denominator = 1, return "2"
            Given numerator = 2, denominator = 3, return "0.(6)"


         */
    }
}
