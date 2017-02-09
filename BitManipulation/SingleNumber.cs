using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BitManipulation
{
    public class SingleNumber
    {
        public static void Run()
        {
            Console.WriteLine(singleNum(new int[] { 1, 2, 2,3 ,1 }));
        }

        public static int singleNum(int[] A)
        {
            int x = 0;
            foreach (int digit in A)
            {
                x = x ^ digit;
            }
            return x;
        }
    }
}
