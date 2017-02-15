using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Recursion
{
    public class Permutations
    {
        public static void Run()
        {
            AlgsDSHelper.Display(permutations(new List<int>(new int[] { 1, 2, 3 })));
        }

        public static List<List<int>> permutations(List<int> A)
        {
            List<List<int>> result = new List<List<int>>();
            directedPermutations(0, A, result);
            return result;
        }

        private static void directedPermutations(int i, List<int> A, List<List<int>> resultList)
        {
            if (i == (A.Count - 1))
            {
                resultList.Add(new List<int>(A));
                return;
            }

            for (int j = i; j < A.Count; j++)
            {
                Swap(A, i, j);
                directedPermutations(i + 1, A, resultList);
                Swap(A, i, j);
            }
        }

        public static void Swap(IList<int> list, int indexA, int indexB)
        {
            int tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}
