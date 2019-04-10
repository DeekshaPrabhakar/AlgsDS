using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BitManipulation
{
    class MaximizingXOR
    {
        public static void Run()
        {
            Console.WriteLine(maxXor(10,15));
        }

        static int maxXor(int l, int r)
        {
            int max = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = l; j <= r; j++)
                {
                    max = (i ^ j) > max ? i ^ j : max;
                }
            }

                return max;
        }
    }
}
