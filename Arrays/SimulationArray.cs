using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Arrays
{
    public class SimulationArray
    {
        public static List<List<int>> diagonal(List<List<int>> A)
        {
            int n = A.Count;
            List<List<int>> outputArray = new List<List<int>>(n);
            List<int> sublist = new List<int>(n);
            int i = 0;
            int j = 0;
            int tempj = j;
            int tempi = i;

            while (j < n)
            {
                sublist = new List<int>(n);

                if (i == 0 && j == 0)
                {
                    sublist.Add(A[i][j]);
                    outputArray.Add(sublist);
                }
                else
                {
                    tempj = j;
                    tempi = i;
                    while (j >= tempi)
                    {
                        sublist.Add(A[i][j]);
                        j--;
                        i++;
                    }
                    j = tempj;
                    i = tempi;
                    outputArray.Add(sublist);
                }
                j++;
            }//half diagonal handled

            i = 1;
            j = n - 1;
            tempj = j;
            tempi = i;

            while (i < n)
            {
                sublist = new List<int>(n);
                if (i == n - 1 && j == n - 1)
                {
                    sublist.Add(A[i][j]);
                    outputArray.Add(sublist);
                }
                else
                {
                    tempj = j;
                    tempi = i;
                    while (i != 0 && i <= tempj)
                    {
                        sublist.Add(A[i][j]);
                        i++;
                        j--;
                    }
                    j = tempj;
                    i = tempi;
                    outputArray.Add(sublist);
                }
                i++;
            }

            return outputArray;
        }
    }
    /*
     *  **** Anti Diagonals *****
     *  Give a N*N square matrix, return an array of its anti-diagonals. Look at the example for more details.
     *  Example:
    	
            Input: 	

            1 2 3
            4 5 6
            7 8 9

            Return the following :

            [ 
              [1],
              [2, 4],
              [3, 5, 7],
              [6, 8],
              [9]
            ]


            Input : 
            1 2
            3 4

            Return the following  : 

            [
              [1],
              [2, 3],
              [4]
            ]


     * 
     */
}
