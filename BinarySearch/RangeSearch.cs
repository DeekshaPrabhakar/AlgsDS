using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.BinarySearch
{
    public class RangeSearch
    {
        public static void Run()
        {
            Console.WriteLine("Binary Search: Search for a Range");
            List<int> listTwo = new List<int>(new int[] { 5, 7, 7, 8, 8, 10 });
            AlgsDSHelper.DisplayList(searchRange(listTwo, 8));
            Console.WriteLine("");
            Console.WriteLine("");
        }
        private static List<int> searchRange(List<int> A, int B)
        {
            int indexStart = BinarySearch(A, A.Count, B, true, 0);
            if (indexStart == -1)
            {
                return new List<int>(new int[]{-1, -1});
            }
            else
            {
                int indexEnd = BinarySearch(A, A.Count, B, false, indexStart);
                return new List<int>(new int[] { indexStart, indexEnd });
            }
        }
        private static int BinarySearch(List<int> A, int n, int x, bool searchFirst, int startIndex)
        {
            int start = startIndex, end = n - 1, result = -1;
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
    /*
     *  *************** Search for a Range *************
     *  

        Given a sorted array of integers, find the starting and ending position of a given target value.

        Your algorithm’s runtime complexity must be in the order of O(log n).

        If the target is not found in the array, return [-1, -1].

        Example:

        Given [5, 7, 7, 8, 8, 10]

        and target value 8,

        return [3, 4].

     */

    /*
     * ************* Java program submitted **********
     * 	// DO NOT MODIFY THE LIST
	    public ArrayList<Integer> searchRange(final List<Integer> a, int b) {
	         ArrayList result  = new ArrayList();
	         int indexStart = BinarySearch(a, a.size(), b, true, 0);
                if (indexStart == -1)
                {
                    result.add(-1);
                    result.add(-1);
                }
                else
                {
                    int indexEnd = BinarySearch(a, a.size(), b, false, indexStart);
                     result.add(indexStart);
                    result.add(indexEnd);
                }
                return result;
	    }
	
	     protected int BinarySearch(List<Integer> A, int n, int x, boolean searchFirst, int startIndex)
            {
                int start = startIndex, end = n - 1, result = -1;
                while (start <= end)
                {
                    int mid = start + (end - start) / 2;
                    if (A.get(mid) == x)
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
                    else if (x < A.get(mid))
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
     * 
     * //for debugging
        public static void main (String[] args) throws java.lang.Exception
        {
	        // your code goes here
	        List<Integer> listTwo = new ArrayList<Integer>();
	        listTwo.add(5);
	        listTwo.add(7);
	        listTwo.add(7);
	        listTwo.add(8);
	        listTwo.add(8);
	        listTwo.add(10);
            DisplayList(searchRange(listTwo, 8));
        }
     * 
	    public static void DisplayList(ArrayList<Integer> list)
        {
            for (Integer value : list)
            {
                System.out.println(value);
            }
                System.out.println();
        }
     */
}
