using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class TwoSum
    {
        public static List<int> twoSum(List<int> A, int B)
        {
            List<List<int>> outputArray = new List<List<int>>();
            Dictionary<int, int> map = new Dictionary<int, int>();//key number and index is value
            for (int i = 0; i < A.Count; i++)
            {
                if (!map.ContainsKey(A[i])) //failing for [1,1,1] target 2.. need to fix the hash
                {
                    map[A[i]] = i;
                }
            }

            int index1 = -1;
            int index2 = -1;

            for (int i = 0; i < A.Count; i++)
            {
                int complement = B - A[i];

                if (map.ContainsKey(complement) && map[complement] != i && i + 1 < map[complement] + 1)//index1 < index2
                {
                    if (index1 == -1)//not set
                    {
                        index1 = i + 1;
                        index2 = map[complement] + 1;
                    }
                    else
                    {
                        if (map[complement] + 1 < index2)
                        {
                            index1 = i + 1;
                            index2 = map[complement] + 1;
                        }
                        else if (map[complement] + 1 == index2 && i + 1 < index1)
                        {
                            index1 = i + 1;
                            index2 = map[complement] + 1;
                        }
                    }
                    outputArray.Add(new List<int>(new int[] { i + 1, map[complement] + 1 }));//not zero based

                }
            }

            if (index1 == -1 && index2 == -1)
            {
                return new List<int>();
            }
            else
            {
                return new List<int>(new int[] { index1, index2 });
            }
        }
    }
}
