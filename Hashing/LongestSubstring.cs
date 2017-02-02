using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class LongestSubstring
    {
        public static int lengthOfLongestSubstring(String A)
        {
            int count = 0;
            int maxLength = 0;
            char[] ACharacterArray = A.ToCharArray();
            int prevIndex;
            Hashtable map = new Hashtable();

            for(int i=0; i< ACharacterArray.Length; i++)
            {
                if(map.ContainsKey(ACharacterArray[i]))
                {
                    prevIndex = int.Parse(map[ACharacterArray[i]].ToString());
                    count = Math.Min(count + 1, i - prevIndex);
                    map[ACharacterArray[i]] = i;
                }
                else
                {
                    count++;
                    map.Add(ACharacterArray[i], i);
                }
                maxLength = Math.Max(maxLength, count);
            }
            maxLength = Math.Max(maxLength, count);
            return maxLength;
        }
    }
}
