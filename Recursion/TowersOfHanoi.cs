using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Recursion
{
    public class TowersOfHanoi
    {
        /*
        This puzzle can be solved using recursion. For a moment, assume that there are just two discs 
         * (disc 1 and 2; disc 2 being the larger one) on the first pole. The solution consists of three steps.

        Step 1: Move disc 1 from pole 1 to pole 2.
        Step 2: Move disc 2 from pole 1 to pole 3.
        Step 3: Move disc 1 from pole 1 to pole 3.
      */
        public static void Run()
        {
            int nDisks = 3;
            solve(nDisks, "A", "B", "C");
        }
       
        public static void solve(int n, String start, String auxiliary, String end)
        {
            if (n == 1)
            {
                Console.WriteLine(start + " -> " + end);
            }
            else
            {
                solve(n - 1, start, end, auxiliary);
                Console.WriteLine(start + " -> " + end);
                solve(n - 1, auxiliary, start, end);
            }
        }      
    }
}
