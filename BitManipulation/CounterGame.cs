using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BitManipulation
{
    class CounterGame
    {
        public static void Run()
        {
            //Console.WriteLine(findWinner(6));
            Console.WriteLine(isPowerofTwo(4));
            Console.WriteLine(isPowerofTwo(6));
        }

        static void counterGame(string[] tests)
        {


        }

        public static string findWinner(int N)
        {
            int movesLeft = 0;

            
            if(movesLeft == 1)
            {
                return "Richard";
            }
            else
            {
                return "Louise";
            }
        }

        private static bool isPowerofTwo(int N)
        {

            while(N%2 == 0)
            {
                N = N / 2;
            }
            if(N==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
