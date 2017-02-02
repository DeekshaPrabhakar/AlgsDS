using AlgsDS.Arrays;
using AlgsDS.BinarySearch;
using AlgsDS.Hashing;
using AlgsDS.LinkedLists;
using AlgsDS.Strings;
using AlgsDS.Trees;
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

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
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

            #region WeekTwoBeforeSession
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("************************* Before Session Assignment ******************");
            //Console.WriteLine("");

            //Console.WriteLine("Hashing: Fraction for 7/9");
            //Console.WriteLine(Fraction.fractionToDecimal(7, 9));
            //Console.WriteLine("");

            //Console.WriteLine("Hashing: Hash table word count for: To be or not to be, that is the question");//hashtable took 2.3287ms
            //DisplayHashtable(WordCount.countWords("To be or not to be, that is the question"));
            //Console.WriteLine("");

            ////Console.WriteLine("Hash table word count for: To be or not to be, that is the question"); //dictionary took 2.6442ms
            ////DisplayDictionary(WordCount.countWords("To be or not to be, that is the question"));
            ////Console.WriteLine("");

            //Console.WriteLine("Linked Lists: Merge Two Sorted Lists: 5 -> 8 -> 20 and 4 -> 11 -> 15");
            //ListNode A = new ListNode(5);
            //A.next = new ListNode(8);
            //A.next.next = new ListNode(20);

            //ListNode B = new ListNode(4);
            //B.next = new ListNode(11);
            //B.next.next = new ListNode(15);
            //DisplayLinkedList(MergeTwoSortedLists.mergeTwoLists(A, B));
            //Console.WriteLine("");
            //Console.WriteLine("");

            //Console.WriteLine("Linked Lists: Add Two Numbers as Lists: (2 -> 4 -> 3) + (5 -> 6 -> 4)");
            //ListNode C = new ListNode(2);
            //C.next = new ListNode(4);
            //C.next.next = new ListNode(3);

            //ListNode D = new ListNode(5);
            //D.next = new ListNode(6);
            //D.next.next = new ListNode(4);

            //DisplayLinkedList(AddTwoNumbersAsLists.addTwoNumbers(C, D));
            #endregion

            #region WeekTwoAfterSession
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("************************* After Session Assignment ******************");
            //Console.WriteLine("");

            //Console.WriteLine("Linked Lists: ReverseSublist: 1->2->3 between 2 and 3");
            //ListNode E = new ListNode(1);
            //E.next = new ListNode(2);
            //E.next.next = new ListNode(3);
            //DisplayLinkedList(ReverseSublist.reverseBetween(E, 2, 3));


            ////Console.WriteLine("Reverse List: 5 -> 8 -> 20 -> 30");
            ////LinkedListNode<int> A = new LinkedListNodeImpl(5);
            ////A.setNext(new LinkedListNodeImpl(8));
            ////A.getNext().setNext(new LinkedListNodeImpl(20));
            ////A.getNext().getNext().setNext(new LinkedListNodeImpl(30));
            ////DisplayLinkedListNode(A);
            ////DisplayLinkedListNode(ReverseList.reverseIterative(A));
            //Console.WriteLine("");

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

            ////List<string> aList = new List<string>(new string[] {"cat", "dog", "god", "tca" });
            ////DisplayListofListofString(FindAnagrams.findAnagrams(aList));

            //Console.WriteLine("Hashing: Multimapss for 'To be or not to be, that is the question'");
            //DisplayDictionaryMultimap(Multimaps.buildMap(WordCount.countWords("To be or not to be, that is the question")));
            //Console.WriteLine("");

            ////Console.WriteLine(LongestSubstring.lengthOfLongestSubstring("Wnb9z9dMc7E8v1RTUaZPoDNIAXRlzkqLaa97KMWLzbitaCkRpiE4J4hJWhRcGnC8H6mwasgDfZ76VKdXhvEYmYrZY4Cfmf4HoSlchYWFEb1xllGKyEEmZOLPh1V6RuM7Mxd7xK72aNrWS4MEaUmgEn7L4rW3o14Nq9l2EN4HH6uJWljI8a5irvuODHY7A7ku4PJY2anSWnfJJE1w8p12Ks3oZRxAF3atqGBlzVQ0gltOwYmeynttUmQ4QBDLDrS4zn4VRZLosOITo4JlIqPD6t4NjhHThOjJxpMp9fICkrgJeGiDAwsb8a3I7Txz5BBKV9bEfMsKNhCuY3W0ZHqY0MhBfz1CbYCzwZZdM4p65ppP9s5QJcfjadmMMi26JKz0TVVwvNA8LP5Vi1QsxId4SI19jfcUH97wmZu0pbw1zFtyJ8GAp5yjjQTzFIboC1iRzklnOJzJld9TMaxqvBNBJKIyDjWrdfLOY8FGMOcPhfJ97Dph35zfxYyUf4DIqFi94lm9J0skYqGz9JT0kiAABQZDazZcNi80dSSdveSl6h3dJjHmlK8qHIlDsqFd5FMhlEirax8WA0v3NDPT8vPhwKpxcnVeu14Gcxr3h1wAXXV0y7Xy9qqB2NQ5HQLJ7cyXAckEYHsLCPSy28xcdNJatx1KLWohOQado4WywJbGvsFR17rKmvOPABweXnFD3odrbSMD4Na4nuBBswvMmFRTUOcf7jZi4z5JnJqXz6hitaPnaEtjoSEBq82a52nvqYy7hhldBoxen2et2OMadVEHeTYLL7GLsIhTP6UizHIuzcJMljo4lFgW5AyrfUlIBPAlhwaSiJtTvcbVZynDSM6RO1PqFKWKg2MHIgNhjuzENg2oFCfW7z5KJvEL9qWqKzZNc0o3BMRjS04NCHFvhtsteQoQRgz84XZBHBJRdekCdcVVXu9c01gYRAz7oIAxN3zKZb64EFKssfQ4HW971jv3H7x5E9dAszA0HrKTONyZDGYtHWt4QLhNsIs8mo4AIN7ecFKewyvGECAnaJpDn1MTTS4yTgZnm6N6qnmfjVt6ZU51F9BxH0jVG0kovTGSjTUkmb1mRTLQE5mTlVHcEz3yBOh4WiFFJjKJdi1HBIBaDL4r45HzaBvmYJPlWIomkqKEmQ4rLAbYG7C5rFfpMu8rHvjU7hP0JVvteGtaGn7mqeKsn7CgrJX1tb8t0ldaS3iUy8SEKAo5IZHNKOfEaij3nI4oRVzeVOZsH91pMsA4jRYgEohubPW8ciXwVrFi1qEWjvB8gfalyP60n1fHyjsiLW0T5uY1JzQWHKCbLVh7QFoJFAEV0L516XmzIo556yRH1vhPnceOCjebqgsmO78AQ8Ir2d4pHFFHAGB9lESn3OtJye1Lcyq9D6X93UakA3JKVKEt6JZDLVBMp4msOefkPKSw59Uix9d9kOQm8WCepJTangdNSOKaxblZDNJ5eHvEroYacBhd9UdafEitdF3nfStF7AhkSfQVC61YWWkKTNdx96OoJGTnxuqt4oFZNFtO7aMuN3IJAkw3m3kgZFRGyd3D3wweagNL9XlYtvZwejbjpkDOZz33C0jbEWaMEaUPw6BG49XqyQoUwtriguO0yvWyaJqD4ye3o0E46huKYAsdKAq6MLWMxF6tfyPVaoqOGd0eOBHbAF89XXmDd4AIkoFPXkAOW8hln5nXnIWP6RBbfEkPPbxoToMbV").ToString());

            //Console.WriteLine("Hashing: TwoSum for [4, 7, -4, 2, 2, 2, 3, -5, -3, 9, -4, 9, -7, 7, -1, 9, 9, 4, 1, -4, -2, 3, -3, -5, 4, -7, 7, 9, -4, 4, -8] with target -3");
            //List<int> listOne = new List<int>(new int[] { 4, 7, -4, 2, 2, 2, 3, -5, -3, 9, -4, 9, -7, 7, -1, 9, 9, 4, 1, -4, -2, 3, -3, -5, 4, -7, 7, 9, -4, 4, -8 });
            //DisplayList(TwoSum.twoSum(listOne, -3));
            //Console.WriteLine("");

            //Console.WriteLine("Hashing: TwoSum for [1, 1, 1 ] with target 2");
            //listOne = new List<int>(new int[] { 1, 1, 1 });
            //DisplayList(TwoSum.twoSum(listOne, 2));
            //Console.WriteLine("");

            //Console.WriteLine("Hashing: TwoSum for [2, 7, 11, 15] with target 9");
            //listOne = new List<int>(new int[] { 2, 7, 11, 15 });
            //DisplayList(TwoSum.twoSum(listOne, 9));
            //Console.WriteLine("");

            //Console.WriteLine(WindowString.minWindow("ADOBECODEBANC", "ABC"));
            //Console.WriteLine(WindowString.minWindow("AAAAAA", "AA"));
            //Console.WriteLine(WindowString.minWindow("0mJdGXwLm9AOZ5xA8u92KDYqGJroQ537hoRXjQoUCMOpDYwxoNjexJGWQJAIxSFF3ZbIe27oFxUTJxtv8mORwpuRZn30MDj3kXRW2Ix3lslj7kwmGZPXAKhBW4q5T2BzsqbL0ZETFqRdxVm8GCGfqshvpWzsRvprUcF9vw3VlftqTRzKRzr4zYB2P6C7lg3I7EhGMPukUj8XGGZTXqPqnCqes", "rsm2ty04PYPEOPYO5")); 
            
            #endregion

            #region WeekThreeBeforeSession

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("************************* Week 3 Before Session Assignment ******************");
            Console.WriteLine("");

            Console.WriteLine("Trees: Valid Binary Search Tree");
            TreeNode notValidBSTOne = new TreeNode(1);
            notValidBSTOne.left = new TreeNode(2);
            notValidBSTOne.right = new TreeNode(3);
            Console.WriteLine(ValidBST.isValidBST(notValidBSTOne));
            Console.WriteLine("");

            TreeNode validBST = new TreeNode(2);
            validBST.left = new TreeNode(1);
            validBST.right = new TreeNode(3);
            Console.WriteLine(ValidBST.isValidBST(validBST));
            Console.WriteLine("");

            TreeNode notValidBST = new TreeNode(3);//11 3 2 4 1 3 -1 -1 -1 -1 -1 -1 
            notValidBST.left = new TreeNode(2);
            notValidBST.left.left = new TreeNode(1);
            notValidBST.left.left.left = new TreeNode(-1);
            notValidBST.left.left.right = new TreeNode(-1);
            notValidBST.left.right = new TreeNode(3);
            notValidBST.right = new TreeNode(4);
            notValidBST.right.left = new TreeNode(-1);
            notValidBST.right.right = new TreeNode(-1);
            Console.WriteLine(ValidBST.isValidBST(notValidBST));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Trees: Inorder Traversal");
            TreeNode inOrderOne = new TreeNode(1);
            inOrderOne.right = new TreeNode(2);
            inOrderOne.right.left = new TreeNode(3);
            DisplayList(Inorder.inorderTraversal(inOrderOne));
            Console.WriteLine("");

            TreeNode inOrder = new TreeNode(314);
            inOrder.left = new TreeNode(6);
            inOrder.left.left = new TreeNode(271);
            inOrder.left.right = new TreeNode(561);
            inOrder.left.left.left = new TreeNode(28);
            inOrder.left.left.right = new TreeNode(0);

            inOrder.left.right.right = new TreeNode(3);
            inOrder.left.right.right.left = new TreeNode(17);

            inOrder.right = new TreeNode(6);
            inOrder.right.left = new TreeNode(2);
            inOrder.right.right = new TreeNode(271);
            DisplayList(Inorder.inorderTraversal(inOrder));
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Trees: Symmetric Binary Tree");
            TreeNode symmetric = new TreeNode(1);
            symmetric.left = new TreeNode(2);
            symmetric.left.left = new TreeNode(3);
            symmetric.left.right = new TreeNode(4);


            symmetric.right = new TreeNode(2);
            symmetric.right.left = new TreeNode(4);
            symmetric.right.right = new TreeNode(3);
            Console.WriteLine(SymmetricBT.isSymmetric(symmetric).ToString());
            Console.WriteLine("");

            TreeNode notSymmetric = new TreeNode(1);
            notSymmetric.left = new TreeNode(2);
            notSymmetric.left.right = new TreeNode(3);


            notSymmetric.right = new TreeNode(2);
            notSymmetric.right.right = new TreeNode(3);
            Console.WriteLine(SymmetricBT.isSymmetric(notSymmetric).ToString());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Binary Search: Count Occurences");
            List<int> listOne = new List<int>(new int[] { 5, 7, 7, 8, 8, 10 });
            Console.WriteLine(CountOccurences.findCount(listOne, 8).ToString());
            Console.WriteLine("");

            Console.WriteLine("Binary Search: Search for a Range");
            List<int> listTwo = new List<int>(new int[] { 5, 7, 7, 8, 8, 10 });
            DisplayList(RangeSearch.searchRange(listTwo, 8));
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Square Root of Integer");
            Console.WriteLine(SquareRoot.IntergerSquareroot(11).ToString());
            Console.WriteLine("");
            Console.WriteLine("");

            #endregion

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

        public static void DisplayDictionaryMultimap(Dictionary<int, List<String>> dict)
        {
            foreach (KeyValuePair<int, List<String>> pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, getListStrings(pair.Value));
            }
            Console.WriteLine();
        }

        protected static string getListStrings(List<String> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            foreach(String str in list)
            {
                sb.Append("'" + str + "', ");
            }
            if (sb.ToString().Length > 3)
            {
                sb.Remove(sb.ToString().Length - 2, 2);
            }
            sb.Append("]");

            return sb.ToString();
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
