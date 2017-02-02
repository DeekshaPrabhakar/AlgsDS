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
        public class Node : IEquatable<Node>
        {
            public int index1;
            public int index2;

            public Node(int ind1, int ind2)
            {
                this.index1 = ind1;
                this.index2 = ind2;
            }

            public bool Equals(Node other)
            {
                if (this.index2 < other.index2)
                    return false;
                if (this.index2 > other.index2)
                    return true;

                return int.Equals(this.index1, other.index1);
            }
        }

        public static List<int> twoSumOne(List<int> A, int B)
        {//LOST COMPLETELY
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            List<int> resultList = new List<int>();
            List<Node> node = new List<Node>();

            int sum = B;
            int diff;
            int size = A.Count;
            int num;
            int index;
           
            for (int i = size - 1; i >= 0; i--)
            {
                num = A[i];
                diff = sum - num;

                if (hashMap.ContainsKey(diff))
                {
                    index = hashMap[diff];
                    node.Add(new Node(i + 1, index + 1));
                }
                if (!hashMap.ContainsKey(num))
                {
                    hashMap.Add(num, i);
                }
            }

            if (node.Count > 0)
            {
                node.Sort();
                resultList.Add(node[0].index1);
                resultList.Add(node[0].index2);
            }

            return resultList;
        }       
    }
}
