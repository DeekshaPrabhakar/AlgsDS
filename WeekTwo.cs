using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS
{
    public class WeekTwo
    {
        public static void run()
        {
            //Console.WriteLine("GetNode");
            //ListNode E = new ListNode(3);
            //E.next = new ListNode(1);
            //E.next.next = new ListNode(3);
            //E.next.next.next = new ListNode(2);
            //E.next.next.next.next = new ListNode(5);
            //DisplayLinkedList(removeNodes(E, 3));

            int noOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<string> inputDataPoints = new List<string>();
            for (int i = 0; i < noOfTestCases; i++)
            {
                inputDataPoints.Add(Console.ReadLine());
            }

            foreach (string datapoint in inputDataPoints)
            {
                Console.WriteLine(minimumChangeForAnagram(datapoint));
            }
        }
        public static void DisplayLinkedList(ListNode list)
        {
            ListNode curr = list;
            while (curr != null)
            {
                if (curr.next != null)
                {
                    Console.Write(curr.val + "->");
                }
                else
                {
                    Console.Write(curr.val);
                }
                curr = curr.next;
            }
        }

        static ListNode removeNodes(ListNode list, int x)
        {
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = list;
            ListNode current = dummyHead.next;
            ListNode prev = dummyHead.next;

            while(current!= null)
            {
                if (current.val > x)
                {
                    prev.next = current.next;
                }
                else
                {
                    prev = current;
                }
                current = current.next;
            }


            return dummyHead.next;
        }

        static string firstRepeatedWord(string s)
        {
            char[] delimiters = new[] { ',', ';', ' ', ':','-','.','\t' };  
            var words = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);            
            List<String> wordList = new List<String>();
            foreach (String word in words)
            {
                if (wordList.Contains(word.ToLower()))
                {
                    return word;
                }
                else
                {
                    wordList.Add(word.ToLower());
                }
            }
            return string.Empty;

        }
        public static int minimumChangeForAnagram(string dataPoint)
        {
            char[] points = dataPoint.ToCharArray();

            if(points.Length %2 != 0)
            {//odd means diving will leave with one greater than another and hence cant be anagram
                return -1;
            }

            int mid = points.Length / 2;
            String A = new String(points, 0, mid);
            String B = new String(points, mid, points.Length-mid);

            char[] aPoints = A.ToCharArray();
            char[] bPoints = B.ToCharArray();

            if (isAnagram(aPoints, bPoints))
            {
                return 0;
            }
            
            List<string> AString = A.Select(c => c.ToString()).ToList();
            Dictionary<string, int> aMap = new Dictionary<string, int>();

            foreach (string s in AString)
            {
                if (aMap.ContainsKey(s))
                {
                    aMap[s]++;
                }
                else
                {
                    aMap.Add(s, 1);
                }
            }

             int count = aMap.Count;

            List<string> BString = B.Select(c => c.ToString()).ToList();
            foreach(string s in BString)
            {
                if(aMap.ContainsKey(s))
                {
                    count--;
                }
            }
            
            Dictionary<string, int> bMap = new Dictionary<string, int>();          
            
            

            

           


             return count;
        }

        public static bool isAnagram(char[] A, char[] B)
        {
            int count = A.Length -1;
            int firstIndex = 0;
            int secondIndex = 0;
            
            while(firstIndex <= count)
            {
                secondIndex = count - firstIndex;
                if(A[firstIndex] != B[secondIndex])
                {
                    return false;
                }
                firstIndex++;
            }
            return true;
        }
    }
}
