using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Arrays
{
    public class SetMatrixZeros
    {
        public static void Run()
        {
            Console.WriteLine("SetMatrixZeros: for");
            List<int> msubList = new List<int>(new int[] { 1, 0, 1 });
            List<List<int>> mList = new List<List<int>>(msubList.Count);
            mList.Add(msubList);
            msubList = new List<int>(new int[] { 1, 1, 1 });
            mList.Add(msubList);
            msubList = new List<int>(new int[] { 1, 1, 1 });
            mList.Add(msubList);
            AlgsDSHelper.Display(mList);
            Console.WriteLine();
            AlgsDSHelper.Display(setMatrixZeros(mList));

            Console.WriteLine();
        }
        private static List<List<int>> setMatrixZeros(List<List<int>> inputArray)
        {
            if (inputArray == null || inputArray.Count == 0)
            {
                return inputArray;
            }

            int m = inputArray.Count;
            int n = inputArray[0].Count;

            bool firstRowZero = false;
            bool firstColZero = false;

            // check if the first row contains zero
            for (int i = 0; i < n; i++)
            {
                if (inputArray[0][i] == 0)
                {
                    firstRowZero = true;
                }
            }

            // check if the first col contains zero
            for (int i = 0; i < m; i++)
            {
                if (inputArray[i][0] == 0)
                {
                    firstColZero = true;
                }
            }

            // check the rest of the matrix elements
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (inputArray[i][j] == 0)
                    {
                        inputArray[0][j] = 0;
                        inputArray[i][0] = 0;
                    }
                }
            }

            // set the corresponding row and col as zero
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (inputArray[i][0] == 0 || inputArray[0][j] == 0)
                    {
                        inputArray[i][j] = 0;
                    }
                }
            }

            // check and set the first row and col as zeros, if necessary
            if (firstRowZero)
            {
                for (int i = 0; i < n; i++)
                {
                    inputArray[0][i] = 0;
                }
            }

            if (firstColZero)
            {
                for (int j = 0; j < m; j++)
                {
                    inputArray[j][0] = 0;
                }
            }

            return inputArray;
        }

        /*     
         * ***** Set Matrix Zeros *****

            Given an m x n matrix of 0s and 1s, if an element is 0, set its entire row and column to 0.

            Do it in place.

            Example

            Given array A as

            1 0 1
            1 1 1 
            1 1 1

            On returning, the array A should be :

            0 0 0
            1 0 1
            1 0 1

            Note that this will be evaluated on the extra memory used. Try to minimize the space and time complexity.

     */
    }
}
