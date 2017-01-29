using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class WordCount
    {
        public static Hashtable countWords(String sentence)
        {
            Hashtable map = new Hashtable();
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            String[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string temp = rgx.Replace(words[i].ToLower(), "");
                if (!map.ContainsKey(temp))
                {
                    map[temp] = 1;
                }
                else
                {
                    map[temp] = int.Parse(map[temp].ToString()) + 1;
                }
            }
            return map;
        }

        //public static Dictionary<string, int> countWords(String sentence)
        //{
        //    Dictionary<string, int> map = new Dictionary<string, int>();
        //    Regex rgx = new Regex("[^a-zA-Z0-9]");
        //    String[] words = sentence.Split(' ');

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        string temp = rgx.Replace(words[i].ToLower(), "");
        //        if (!map.ContainsKey(temp))
        //        {
        //            map[temp] = 1;
        //        }
        //        else
        //        {
        //            map[temp]++;
        //        }
        //    }
        //    return map;
        //}

        /*
         * **************  Hash table word count ***************
         * Write a program which takes as its input a String of natural language text and outputs a HashMap<String,Integer> whose keys are the unique words in the input and whose values are the number of times those words occur. The algorithm should be case-insensitive (e.g. "Program" and "program" would count as the same word) and ignore punctuation and whitespace.

            Example: Given the input "To be or not to be, that is the question", the outputted HashMap would contain 8 entries, with two words having a count of 2 and six words having a count of 1:

            "to"        → 2
            "be"        → 2
            "or"        → 1
            "not"       → 1
            "that"      → 1
            "is"        → 1
            "the"       → 1
            "question"  → 1

         */
    }
}
