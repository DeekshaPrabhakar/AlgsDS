﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BinarySearch
{
    public class CountOccurences
    {
        public static int findCount(List<int> A, int B)
        {
            int indexStart = BinarySearch(A, A.Count, B, true);
            if (indexStart == -1)
            {
                return 0;
            }
            else
            {
                int indexEnd = BinarySearch(A, A.Count, B, false);
                return indexEnd - indexStart + 1;
            }
        }

        protected static int BinarySearch(List<int> A, int n, int x, bool searchFirst)
        {
            int start = 0, end = n - 1, result = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (A[mid] == x)
                {
                    result = mid;
                    if (searchFirst)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else if (x < A[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return result;
        }
    
    }
}
