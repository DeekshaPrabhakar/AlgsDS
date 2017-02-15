using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BitManipulation
{
    public class ReverseBits
    {
        public static void Run()
        {
            Console.WriteLine(reverse(43261596));
        }


        public static int reverse(int A)
        {
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                result = (result << 1) | (A & 1);
                A = (A >> 1);
            }

            return result;
        }
    }
}
