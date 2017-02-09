using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Recursion
{
    public class Factorial
    {
        public static void Run()
        {
            Console.WriteLine(FindFactorial(5));
        }

        private static int FindFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * FindFactorial(n - 1);
        }
    }
}
