using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AlgsDS.Hashing
{
    public class FindAnagrams
    {
        public static void Run()
        {
            Console.WriteLine("Hashing: Anagrams index for : cat, dog, god, tca");
            List<string> aList = new List<string>(new string[] { "cat", "dog", "god", "tca" });
            AlgsDSHelper.Display(anagrams(aList));
            Console.WriteLine("");

            Console.WriteLine("Hashing: Anagrams index for : cat, dog, god, tca");
            List<string> bList = new List<string>(new string[] { "abbbaabbbabbbbabababbbbbbbaabaaabbaaababbabbabbaababbbaaabbabaabbaabbabbbbbababbbababbbbaabababba", "abaaabbbabaaabbbbabaabbabaaaababbbbabbbaaaabaababbbbaaaabbbaaaabaabbaaabbaabaaabbabbaaaababbabbaa", "babbabbaaabbbbabaaaabaabaabbbabaabaaabbbbbbabbabababbbabaabaabbaabaabaabbaabbbabaabbbabaaaabbbbab", "bbbabaaabaaaaabaabaaaaaaabbabaaaabbababbabbabbaabbabaaabaabbbabbaabaabaabaaaabbabbabaaababbaababb", "abbbbbbbbbbbbabaabbbbabababaabaabbbababbabbabaaaabaabbabbaaabbaaaabbaabbbbbaaaabaaaaababababaabab", "aabbbbaaabbaabbbbabbbbbaabbababbbbababbbabaabbbbbbababaaaabbbabaabbbbabbbababbbaaabbabaaaabaaaaba", "abbaaababbbabbbbabababbbababbbaaaaabbbbbbaaaabbaaabbbbbbabbabbabbaabbbbaabaabbababbbaabbbaababbaa", "aabaaabaaaaaabbbbaabbabaaaabbaababaaabbabbaaaaababaaabaabbbabbababaabababbaabaababbaabbabbbaaabbb" });
            AlgsDSHelper.Display(anagrams(bList));
            Console.WriteLine("");

            List<string> cList = new List<string>(new string[] { "cat", "dog", "god", "tca" });
            AlgsDSHelper.DisplayListofListofString(findAnagrams(cList));
        }
        private static List<List<string>> findAnagrams(List<string> dictionary)
        {
            Dictionary<string, List<string>> sortedStringToAnagrams = new Dictionary<string, List<string>>();
            foreach (String s in dictionary)
            {
                char[] sortedCharArray = s.ToCharArray();
                Array.Sort(sortedCharArray);
                String sortedStr = new string(sortedCharArray);

                if (!sortedStringToAnagrams.ContainsKey(sortedStr))
                {
                    sortedStringToAnagrams.Add(sortedStr, new List<string>());
                }

                sortedStringToAnagrams[sortedStr].Add(s);
            }

            List<List<string>> anagramGroups = new List<List<string>>();

            foreach (List<string> p in sortedStringToAnagrams.Values)
            {
                if (p.Count >= 2)
                {
                    anagramGroups.Add(p);
                }
            }

            return anagramGroups;
        }

        private static List<List<int>> anagrams(List<string> A)
        {
            Dictionary<string, List<int>> sortedStringToAnagrams = new Dictionary<string, List<int>>();
            for (int i = 0; i < A.Count; i++)
            {
                string s = A[i];
                char[] sortedCharArray = s.ToCharArray();
                Array.Sort(sortedCharArray);
                String sortedStr = new string(sortedCharArray);

                if (!sortedStringToAnagrams.ContainsKey(sortedStr))
                {
                    sortedStringToAnagrams.Add(sortedStr, new List<int>());
                }

                sortedStringToAnagrams[sortedStr].Add(i + 1);
            }

            List<List<int>> anagramGroups = new List<List<int>>();

            foreach (List<int> p in sortedStringToAnagrams.Values)
            {
                if (p.Count >= 2)
                {
                    anagramGroups.Add(p);
                }
                else if (p.Count == 1)
                {
                    anagramGroups.Add(p);
                }
            }

            return anagramGroups;
        }
    }
}
