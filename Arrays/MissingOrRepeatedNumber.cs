using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Arrays
{
    public class MissingOrRepeatedNumber
    {
        public static int repeatedNumber(List<int> A)
        {
            A.Sort();
            int firstNumber = -1;
            int secondNumber = -1;
            for (int i = 0; i < A.Count; i++)
            {
                firstNumber = A[i];
                secondNumber = A[i + 1];
                if (firstNumber == secondNumber)
                {
                    return firstNumber;
                }
            }

            return -1;
        }
    }
    /*
     ***** Find Duplicate in Array *****     

            Given a read only array of n + 1 integers between 1 and n, find one number that repeats in linear time using less than O(n) space and traversing the stream sequentially O(1) times.

            Sample Input:

            [3 4 1 4 1]

            Sample Output:

            1

            If there are multiple possible answers ( like in the sample case above ), output any one.

            If there is no duplicate, output -1
     */
}
