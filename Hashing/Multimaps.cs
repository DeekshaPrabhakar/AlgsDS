using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class Multimaps
    {
        public static void Run()
        {
            Console.WriteLine("Hashing: Multimapss for 'To be or not to be, that is the question'");
            AlgsDSHelper.DisplayDictionaryMultimap(buildMap(WordCount.countWords("To be or not to be, that is the question")));
            Console.WriteLine("");
        }
        private static Dictionary<int, List<String>> buildMap(Hashtable map)
        {
            Dictionary<int, List<String>> resultMap =  new Dictionary<int,List<string>>();

            foreach(DictionaryEntry pair in map)
            {
                int wordCount = int.Parse(pair.Value.ToString());
                if (!resultMap.ContainsKey(wordCount))
                {
                    resultMap.Add(wordCount, new List<string>());
                }
                resultMap[wordCount].Add(pair.Key.ToString());
            }

            return resultMap;
        }

    }

    /*
     * **************** Multimaps *******************
        One common pattern when using hash tables requires building a Map whose values are Collection instances. In this challenge, we'll take the output of the previous challenge and invert it.

        Write a program that takes as its input a HashMap<String,Integer> and returns a HashMap<Integer,HashSet<String>> containing the same data as the input map, only inverted, such that the input map's values are the output map's keys and the input map's keys are the output map's values.

        Example:

        Consider the example output for Challenge #4. Using that map as the input, the output for this challenge would be:

        2 → ["to", "be"]
        1 → ["or", "not", "that", "is", "the", "question"]

     */
}
