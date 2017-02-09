using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Recursion
{
    public class Subset
    {
        public static void Run()
        {
            AlgsDSHelper.Display(subsets(new List<int>(new int[] {1,2,3,})));
        }

        public static List<List<int>> subsets(List<int> A)
        {
            A.Sort();
            List<List<int>> resultList = new List<List<int>>();
            subset(A, A.Count, resultList);
            subsetLast(A, A.Count - 2, resultList); 
            return resultList;
        }

        public static void subset(List<int> A, int startIndex,List<List<int>> result)
        {
            if (startIndex < 0)
            {
                return;
            }

            List<int> sublist = new List<int>(A);
            sublist = sublist.GetRange(0, A.Count - startIndex);
            result.Add(sublist);
            startIndex = startIndex - 1;
            subset(A, startIndex,  result);
        }

        public static void subsetLast(List<int> A, int removeIndex, List<List<int>> result)
        {
            if (removeIndex < 0)
            {
                return;
            }

            List<int> sublist = new List<int>(A);
            result.Add(new List<int>(new int[]{ A[removeIndex]}));
            sublist.Remove(A[removeIndex]);
            result.Add(sublist);
            removeIndex = removeIndex - 1;
            subsetLast(A, removeIndex, result);
        }
    }
}
