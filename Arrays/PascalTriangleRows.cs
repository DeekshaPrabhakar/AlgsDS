using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Arrays
{
    public class PascalTriangleRows
    {
        public static List<List<int>> generate(int A)
        {
            List<List<int>> pascalTriangle = new List<List<int>>();
            List<int> row = new List<int>();

            for (int i = 0; i < A; i++)
            {
                row = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    row.Add((j > 0 && j < i) ? pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j] : 1);
                }
                pascalTriangle.Add(row);
            }

            return pascalTriangle;
        }
        /*  *  **** Pascal Triangle Rows *****
     * 

        Given numRows, generate the first numRows of Pascal’s triangle.

        Pascal’s triangle : To generate A[C] in row R, sum up A’[C] and A’[C-1] from previous row R - 1.

        Example:

        Given numRows = 5,

        Return

        [
             [1],
             [1,1],
             [1,2,1],
             [1,3,3,1],
             [1,4,6,4,1]
        ]


    */
    }
}
