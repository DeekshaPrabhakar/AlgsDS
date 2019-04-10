using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Tests
{
    class Time
    {
        public static void Run()
        {
            Console.WriteLine(solution("15:15:00", "15:15:12"));
        }
        public static int solution(string S, string T)
        {
            int count = 0;
            DateTime start = DateTime.Parse(S);
            DateTime end = DateTime.Parse(T);
            return 0;
        }
    }
}
