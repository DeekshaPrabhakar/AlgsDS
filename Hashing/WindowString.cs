using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class WindowString
    {
        public static void Run()
        {
            Console.WriteLine(minWindow("ADOBECODEBANC", "ABC"));
            Console.WriteLine(minWindow("AAAAAA", "AA"));
            Console.WriteLine(minWindow("0mJdGXwLm9AOZ5xA8u92KDYqGJroQ537hoRXjQoUCMOpDYwxoNjexJGWQJAIxSFF3ZbIe27oFxUTJxtv8mORwpuRZn30MDj3kXRW2Ix3lslj7kwmGZPXAKhBW4q5T2BzsqbL0ZETFqRdxVm8GCGfqshvpWzsRvprUcF9vw3VlftqTRzKRzr4zYB2P6C7lg3I7EhGMPukUj8XGGZTXqPqnCqes", "rsm2ty04PYPEOPYO5")); 
        }
        private static string minWindow(string A, string B)
        {
            char[] SCharacterArray = A.ToCharArray();
            char[] TCharacterArray = B.ToCharArray();
            Hashtable resultMap = new Hashtable();

            //aabcd aab   abcdaa
            Hashtable targetMap = new Hashtable();
            for(int j=0; j< TCharacterArray.Length; j++)
            {
                if (!targetMap.ContainsKey(TCharacterArray[j].ToString()))
                {
                    targetMap.Add(TCharacterArray[j].ToString(), 1);
                }
                else
                {
                    targetMap[TCharacterArray[j].ToString()] = int.Parse(targetMap[TCharacterArray[j].ToString()].ToString()) + 1;
                }
            }

            resultMap = new Hashtable(targetMap);
            string minimumWindow = "";
            StringBuilder sb = new StringBuilder();
            int size = TCharacterArray.Length;
            bool subStringStarted = false;
            
            for(int i=0; i<SCharacterArray.Length; i++)
            {
                if (!subStringStarted && targetMap.ContainsKey(SCharacterArray[i].ToString()))
                {
                    subStringStarted = true;
                }

                if(subStringStarted && size >=0)
                {
                    if (targetMap.ContainsKey(SCharacterArray[i].ToString()))
                    {
                        int count = int.Parse(targetMap[SCharacterArray[i].ToString()].ToString());
                        if (count > 1)
                        {
                            resultMap[SCharacterArray[i].ToString()] = count - 1;
                            if (int.Parse(resultMap[SCharacterArray[i].ToString()].ToString()) == 0)
                            {
                                resultMap.Remove(SCharacterArray[i].ToString());
                            }
                        }
                        else
                        {
                            resultMap.Remove(SCharacterArray[i].ToString());
                        }
                        size--;
                        sb.Append(SCharacterArray[i].ToString());
                    }
                    else
                    {
                        sb.Append(SCharacterArray[i].ToString());
                    }
                                       

                    if(size ==0)
                    {
                        string window = sb.ToString();
                        if (window.Length < minimumWindow.Length || minimumWindow == "")
                        {
                            minimumWindow = sb.ToString();
                        }
                        sb = new StringBuilder();
                        subStringStarted = false;
                        size = TCharacterArray.Length;
                        resultMap = new Hashtable(targetMap);
                    }
                }
            }
            return minimumWindow;
        }
    }
}
