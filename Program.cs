using AlgsDS.Arrays;
using AlgsDS.Hashing;
using AlgsDS.LinkedLists;
using AlgsDS.Strings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }

    public interface LinkedListNode<T>
    {
        /* getter/setter for this node's value */
        T getValue();
        void setValue(T value);

        /* getter/setter for the subsequent node, or null if this is the last node */
        LinkedListNode<T> getNext();
        void setNext(LinkedListNode<T> next);

        /**
         * Initialize this node and all of its subsequent nodes from
         * an array of values, starting with the head value at index 0
         *
         * @param listValues - the ordered values for the whole list
         */
        void setValuesFromArray(T[] listValues);
    }

    public class LinkedListNodeImpl : LinkedListNode<int>
    {
        private int data;
        private LinkedListNode<int> next;

        public LinkedListNodeImpl()
        {
        }

        public LinkedListNodeImpl(int val)
        {
            this.data = val;
            this.next = null;
        }

        public int getValue()
        {
            return this.data;
        }

        public void setValue(int val)
        {
            this.data = val;
        }

        public LinkedListNode<int> getNext()
        {
            return this.next;
        }

        public void setNext(LinkedListNode<int> next)
        {
            this.next = next;
        }

        public void setValuesFromArray(int[] listValues)
        {
            LinkedListNode<int> dummyHead = this;
            LinkedListNode<int> current = dummyHead;


            for (int i = 0; i < listValues.Length; i++)
            {
                current.setValue(listValues[i]);
                if (current.getNext() == null)
                {
                    current.setNext(new LinkedListNodeImpl());
                }
                current = current.getNext();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region WeekOne
            //Console.WriteLine("AddOneToNumber: [0]");
            //DisplayList(AddOneToNumber.plusOne(new List<int>(new int[] { 0 })));
            //Console.WriteLine("AddOneToNumber: [0, 0, 0, 2, 5, 6, 8, 6, 1, 2, 4, 5]");
            //DisplayList(AddOneToNumber.plusOne(new List<int>(new int[] { 0, 0, 0, 2, 5, 6, 8, 6, 1, 2, 4, 5 })));

            //Console.WriteLine();

            //List<int> dsubList = new List<int>(new int[] { 1, 2, 3 });
            //List<List<int>> dList = new List<List<int>>(dsubList.Count);
            //dList.Add(dsubList);
            //dsubList = new List<int>(new int[] { 4, 5, 6 });
            //dList.Add(dsubList);
            //dsubList = new List<int>(new int[] { 7, 8, 9 });
            //dList.Add(dsubList);

            //Console.WriteLine("AntiDiagonals for input: ");
            //Display(dList);
            //Console.WriteLine();
            //Display(AntiDiagonals.diagonal(dList));

            //Console.WriteLine();

            //Console.WriteLine("FindDuplicateInArray: [3,4,1,4,1]");
            //Console.WriteLine(FindDuplicateInArray.repeatedNumber(new List<int>(new int[] { 3, 4, 1, 4, 1 })));

            //Console.WriteLine();

            //Console.WriteLine("PascalTriangleRows: for 5 rows");
            //Display(PascalTriangleRows.generate(5));

            //Console.WriteLine();

            //Console.WriteLine("SetMatrixZeros: for");
            //List<int> msubList = new List<int>(new int[] { 1, 0, 1 });
            //List<List<int>> mList = new List<List<int>>(msubList.Count);
            //mList.Add(msubList);
            //msubList = new List<int>(new int[] { 1, 1, 1 });
            //mList.Add(msubList);
            //msubList = new List<int>(new int[] { 1, 1, 1 });
            //mList.Add(msubList);
            //Display(mList);
            //Console.WriteLine();
            //Display(SetMatrixZeros.setMatrixZeros(mList));

            //Console.WriteLine();

            //Console.WriteLine("AddBinaryStrings: " + "110, " + "11");
            //Console.WriteLine(AddBinaryStrings.addBinary("110", "11"));

            //Console.WriteLine("AddBinaryStrings: " + "100, " + "11");
            //Console.WriteLine(AddBinaryStrings.addBinary("100", "11"));

            //Console.WriteLine("AddBinaryStrings: " + "1010110111001101101000, " + "1000011011000000111100110");
            //Console.WriteLine(AddBinaryStrings.addBinary("1010110111001101101000", "1000011011000000111100110"));

            //Console.WriteLine();

            //Console.WriteLine("LengthOfLastWord: Hello world  ");
            //Console.WriteLine(LengthOfLastWord.lengthOfLastWord("Hello world  "));

            //Console.WriteLine();

            //Console.WriteLine("ReverseTheString:    fwbpudnbrozzifml osdt  ulc jsx kxorifrhubk ouhsuhf  sswz qfho dqmy  sn myq igjgip iwfcqq");
            //Console.WriteLine(ReverseTheString.reverseWords("   fwbpudnbrozzifml osdt  ulc jsx kxorifrhubk ouhsuhf  sswz qfho dqmy  sn myq igjgip iwfcqq"));

            //Console.WriteLine();

            //String input = "{A:\"B\",C:{D:\"E\",F:{G:\"H\",I:\"J\"}}}";
            //Console.WriteLine("PrettyJSON for " + input);
            //DisplayJSON(PrettyJSON.prettyJSON(input));

            //input = "[\"foo\", {\"bar\":[\"baz\",null,1.0,2]}]";
            //Console.WriteLine("PrettyJSON for " + input);
            //DisplayJSON(PrettyJSON.prettyJSON(input));

            //input = "{\"id\":100,\"firstName\":\"Jack\",\"lastName\":\"Jones\",\"age\":12}";
            //Console.WriteLine("PrettyJSON for " + input);
            //DisplayJSON(PrettyJSON.prettyJSON(input));

            //input = "{\"attributes\":[{\"nm\":\"ACCOUNT\",\"lv\":[{\"v\":{\"Id\":null,\"State\":null},\"vt\":\"java.util.Map\",\"cn\":1}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":13585},{\"nm\":\"PROFILE\",\"lv\":[{\"v\":{\"Party\":null,\"Ads\":null},\"vt\":\"java.util.Map\",\"cn\":2}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":41962}]}";
            //Console.WriteLine("PrettyJSON for " + input);
            //DisplayJSON(PrettyJSON.prettyJSON(input));

            //Console.WriteLine();

            //Console.WriteLine(PalindromeString.isPalindrome("\"A man, a plan, a canal: Panama][:\"").ToString());//1
            //Console.WriteLine(PalindromeString.isPalindrome("race a car").ToString());//0
            //Console.WriteLine(PalindromeString.isPalindrome("1a2").ToString());//0
            //Console.WriteLine(PalindromeString.isPalindrome("a").ToString());//1 
            #endregion

            #region BeforeSession
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("************************* Before Session Assignment ******************");
            Console.WriteLine("");

            Console.WriteLine("Hashing: Fraction for 7/9");
            Console.WriteLine(Fraction.fractionToDecimal(7, 9));
            Console.WriteLine("");

            Console.WriteLine("Hashing: Hash table word count for: To be or not to be, that is the question");//hashtable took 2.3287ms
            DisplayHashtable(WordCount.countWords("To be or not to be, that is the question"));
            Console.WriteLine("");

            //Console.WriteLine("Hash table word count for: To be or not to be, that is the question"); //dictionary took 2.6442ms
            //DisplayDictionary(WordCount.countWords("To be or not to be, that is the question"));
            //Console.WriteLine("");

            Console.WriteLine("Linked Lists: Merge Two Sorted Lists: 5 -> 8 -> 20 and 4 -> 11 -> 15");
            ListNode A = new ListNode(5);
            A.next = new ListNode(8);
            A.next.next = new ListNode(20);

            ListNode B = new ListNode(4);
            B.next = new ListNode(11);
            B.next.next = new ListNode(15);
            DisplayLinkedList(MergeTwoSortedLists.mergeTwoLists(A, B));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Linked Lists: Add Two Numbers as Lists: (2 -> 4 -> 3) + (5 -> 6 -> 4)");
            ListNode C = new ListNode(2);
            C.next = new ListNode(4);
            C.next.next = new ListNode(3);

            ListNode D = new ListNode(5);
            D.next = new ListNode(6);
            D.next.next = new ListNode(4);

            DisplayLinkedList(AddTwoNumbersAsLists.addTwoNumbers(C, D)); 
            #endregion
            
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("************************* After Session Assignment ******************");            
            //Console.WriteLine("");

            //Console.WriteLine("Linked Lists: ReverseSublist: 1->2->3 between 2 and 3");
            //ListNode E = new ListNode(1);
            //E.next = new ListNode(2);
            //E.next.next = new ListNode(3);
            //DisplayLinkedList(ReverseSublist.reverseBetween(E, 2, 3));
            //Console.WriteLine("");

            //Console.WriteLine("Linked Lists: Implementation test");
            //LinkedListImplementation.test();
            //Console.WriteLine("");

            //Console.WriteLine("Hashing: Anagrams index for : cat, dog, god, tca");
            //List<string> aList = new List<string>(new string[] { "cat", "dog", "god", "tca" });
            //Display(FindAnagrams.anagrams(aList));
            //Console.WriteLine("");

            ////Console.WriteLine("Hashing: Anagrams index for : cat, dog, god, tca");
            ////List<string> bList = new List<string>(new string[] { "abbbaabbbabbbbabababbbbbbbaabaaabbaaababbabbabbaababbbaaabbabaabbaabbabbbbbababbbababbbbaabababba", "abaaabbbabaaabbbbabaabbabaaaababbbbabbbaaaabaababbbbaaaabbbaaaabaabbaaabbaabaaabbabbaaaababbabbaa", "babbabbaaabbbbabaaaabaabaabbbabaabaaabbbbbbabbabababbbabaabaabbaabaabaabbaabbbabaabbbabaaaabbbbab", "bbbabaaabaaaaabaabaaaaaaabbabaaaabbababbabbabbaabbabaaabaabbbabbaabaabaabaaaabbabbabaaababbaababb", "abbbbbbbbbbbbabaabbbbabababaabaabbbababbabbabaaaabaabbabbaaabbaaaabbaabbbbbaaaabaaaaababababaabab", "aabbbbaaabbaabbbbabbbbbaabbababbbbababbbabaabbbbbbababaaaabbbabaabbbbabbbababbbaaabbabaaaabaaaaba", "abbaaababbbabbbbabababbbababbbaaaaabbbbbbaaaabbaaabbbbbbabbabbabbaabbbbaabaabbababbbaabbbaababbaa", "aabaaabaaaaaabbbbaabbabaaaabbaababaaabbabbaaaaababaaabaabbbabbababaabababbaabaababbaabbabbbaaabbb" });
            ////Display(FindAnagrams.anagrams(bList));
            ////Console.WriteLine("");

           

            ////Console.WriteLine("Multimapss for: To be or not to be, that is the question");
            ////DisplayDictionary(WordCount.countWords("To be or not to be, that is the question"));
            ////Console.WriteLine("");

            ////List<string> aList = new List<string>(new string[] {"cat", "dog", "god", "tca" });
            ////DisplayListofListofString(FindAnagrams.findAnagrams(aList));
            
            
            ////Console.WriteLine("Reverse List: 5 -> 8 -> 20 -> 30");
            ////LinkedListNode<int> A = new LinkedListNodeImpl(5);
            ////A.setNext(new LinkedListNodeImpl(8));
            ////A.getNext().setNext(new LinkedListNodeImpl(20));
            ////A.getNext().getNext().setNext(new LinkedListNodeImpl(30));
            ////DisplayLinkedListNode(A);
            ////DisplayLinkedListNode(ReverseList.reverseIterative(A));

            ////Stopwatch sw = new Stopwatch();
            ////sw.Start();
            ////sw.Stop();
            ////Console.WriteLine("Elapsed={0}", sw.Elapsed.TotalMilliseconds);

            Console.ReadLine();
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

        public static void DisplayLinkedListNode(LinkedListNode<int> list)
        {
            LinkedListNode<int> curr = list;
            while (curr != null)
            {
                if (curr.getNext() != null)
                {
                    Console.Write(curr.getValue() + "->");
                }
                else
                {
                    Console.Write(curr.getValue());
                }
                curr = curr.getNext();
            }
        }

        public static void DisplayJSON(List<String> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        public static void Display(List<List<int>> list)
        {
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void DisplayListofListofString(List<List<string>> list)
        {
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void DisplayList(List<int> list)
        {
            foreach (var value in list)
            {
                Console.Write(value);
                Console.Write(' ');
            }
                Console.WriteLine();
        }

        public static void DisplayDictionary(Dictionary<string, int> dict)
        {
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
        }

        public static void DisplayHashtable(Hashtable map)
        {
            foreach (DictionaryEntry pair in map)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
        }

    }
}
