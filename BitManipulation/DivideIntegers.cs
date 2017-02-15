using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BitManipulation
{
    public class DivideIntegers
    {
        public static void Run()
        {
            Console.WriteLine(divide(6, 3));
        }
        public static int divide(int A, int B)
        {
            //handle special cases
            if (B == 0) return int.MaxValue;
            if (B == -1 && A == int.MinValue)
                return int.MaxValue;

            //get positive values
            long pDividend = Math.Abs((long)A);
            long pDivisor = Math.Abs((long)B);

            int result = 0;
            while (pDividend >= pDivisor)
            {
                //calculate number of left shifts
                int numShift = 0;
                while (pDividend >= (pDivisor << numShift))
                {
                    numShift++;
                }

                //dividend minus the largest shifted divisor
                result += 1 << (numShift - 1);
                pDividend -= (pDivisor << (numShift - 1));
            }

            if ((A > 0 && B > 0) || (A < 0 && B < 0))
            {
                return result;
            }
            else
            {
                return -result;
            }
        }
    }
}
