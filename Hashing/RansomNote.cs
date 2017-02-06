using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class RansomNote
    {
        public static void Run()
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach(string s in magazine)
            {
                String sLower = s.ToLower();
                if (map.ContainsKey(sLower))
                {
                    map[sLower] = map[sLower] + 1;
                }
                else
                {
                    map.Add(sLower, 1);
                }
            }

            foreach(string s in ransom)
            {
                 String sLower = s.ToLower();
                if(map.ContainsKey(sLower))
                {
                    map[sLower] = map[sLower] - 1;
                    if (map[sLower] == 0)
                    {
                        map.Remove(sLower);
                    }
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
