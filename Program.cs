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

    public class Node
    {
        public int data;
        public Node next;
        public Node prev;
        public Node(int x)
        {
            this.data = x;
            this.next = null;
            this.prev = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region WeekOne

            //AddOneToNumber.Run();
            //AntiDiagonals.Run();
            //FindDuplicateInArray.Run();
            //PascalTriangleRows.Run();
            //SetMatrixZeros.Run();

            //AddBinaryStrings.Run();
            //LengthOfLastWord.Run();
            //ReverseTheString.Run();
            //PrettyJSON.Run();
            //PalindromeString.Run();
          
            #endregion

            #region WeekTwo
            
            //Fraction.Run();
            //WordCount.Run();
            //AddTwoNumbersAsLists.Run();
            //ReverseSublist.Run();
            //ReverseList.Run();
            //LinkedListImplementation.Run();
            //FindAnagrams.Run();

            //Multimaps.Run();
            //LongestSubstring.Run();
            //TwoSum.Run();
            //WindowString.Run();
            //DetectCycle.Run();
            //RemoveDuplicates.Run();
            //Palindrome.Run();
            //RemoveDuplicatesII.Run();
            //GetNode.Run();
            //MergePoint.Run();
            //ReverseDoublyLinkedList.Run();
            //InsertNodeSortedDoublyLL.Run();
            //RansomNote.Run();
            //PhoneBook.Run();

            #endregion

            #region WeekThreeBeforeSession

            //ValidBST.Run();
            //Inorder.Run();
            //SymmetricBT.Run();
            //CountOccurences.Run();
            //RangeSearch.Run();
            //SquareRoot.Run();

            //Preorder.Run();
            //PostOrder.Run();
            RotatedArray.Run();

            #endregion

            //WeekTwo.run();
            Console.ReadLine();
        }

      

    }
}
