using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Hashing
{
    public class TwoSum
    {
        public class Node : IComparable<Node>
        {
            public int index1;
            public int index2;

            public Node(int ind1, int ind2)
            {
                this.index1 = ind1;
                this.index2 = ind2;
            }

            public int CompareTo(Node other)
            {
                if (this.index2 < other.index2)
                    return -1;
                if (this.index2 > other.index2)
                    return 1;
                return this.index1.CompareTo(other.index1);
            }
        }

        public static List<int> twoSum(List<int> A, int B)
        {
            Hashtable hashMap = new Hashtable();
            List<int> resultList = new List<int>();
            List<Node> resultIndexesList = new List<Node>();

            int sum = B;
            int diff;
            int size = A.Count;
            int num;
            int index;
            
            //go through array from last
            for (int i = size - 1; i >= 0; i--)
            {
                num = A[i];
                diff = sum - num;

                //if difference found for current number,store current index and difference index
                if (hashMap.ContainsKey(diff))
                {
                    index = int.Parse(hashMap[diff].ToString());  
                    resultIndexesList.Add(new Node(i + 1, index + 1));
                }

                //store input characters and index in hashtable
                if (!hashMap.ContainsKey(num))
                {
                    hashMap.Add(num, i);//1,1
                }
                else
                {//update index if number founnd 
                    hashMap[num] = i;//1,0
                }
            }

            if (resultIndexesList.Count > 0)
            {
                resultIndexesList.Sort();//sort based on index1 < index2 and for for same index2 minimum index1
                resultList.Add(resultIndexesList[0].index1);
                resultList.Add(resultIndexesList[0].index2);
            }

            return resultList;
        }       
    }
    /*
     * ****************** 2 Sum ********************
     
        Given an array of integers, find two numbers such that they add up to a specific target number.

        The function twoSum should return indices of the two numbers such that they add up to the target, where index1 < index2. Please note that your returned answers (both index1 and index2 ) are not zero-based.
        Put both these numbers in order in an array and return the array from your function ( Looking at the function signature will make things clearer ). Note that, if no pair exists, return empty list.

        If multiple solutions exist, output the one where index2 is minimum. If there are multiple solutions with the minimum index2, choose the one with minimum index1 out of them.

        Input: [2, 7, 11, 15], target=9
        Output: index1 = 1, index2 = 2


     */
}
