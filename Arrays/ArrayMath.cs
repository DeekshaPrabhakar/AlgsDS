using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Arrays
{
    public class ArrayMath
    {
        public static List<int> plusOne(List<int> A)
        {
            List<int> outputArray = new List<int>();
            int carry = 1;

            int nonZeroIndex = 0;
            int j = 0;
            while (A[j] == 0 && A.Count != 1)
            {
                nonZeroIndex++;
                j++;
            }


            for (int i = A.Count - 1; i >= nonZeroIndex; i--)
            {
                int val = A[i] + carry;
                outputArray.Add(val % 10);
                carry = val / 10;
            }
            if (carry == 1)
            {
                outputArray.Add(1);
            }
            outputArray.Reverse();
            return outputArray;
        }
    }
}
