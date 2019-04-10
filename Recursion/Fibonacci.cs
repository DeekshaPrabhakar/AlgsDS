using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Recursion
{
    public class Fibonacci
    {
        public static void Run()
        {
            Console.WriteLine(FibonacciOf(6));
        }
        public static int FibonacciOf(int n)
        {
            int sum = 0;
            if(n==0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            sum = FibonacciOf(n - 1) + FibonacciOf(n - 2);
            return sum;
        }
    }
}
