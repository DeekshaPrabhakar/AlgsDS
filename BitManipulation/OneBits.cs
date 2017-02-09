using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BitManipulation
{
    public class OneBits
    {
        public static void Run()
        {
            Console.WriteLine(countOne(11));
        }
        public static int countOne(int x)
        {
            int noOfBits = 0;

            while (x != 0)
            {
                noOfBits += (x & 1);
                x >>= 1;
            }

            return noOfBits;
        }
    }
}
