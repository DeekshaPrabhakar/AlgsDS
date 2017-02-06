using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class ReverseList
    {
        public static void Run()
        {
            Console.WriteLine("Reverse List: 5 -> 8 -> 20 -> 30");
            LinkedListNode<int> A = new LinkedListNodeImpl(5);
            A.setNext(new LinkedListNodeImpl(8));
            A.getNext().setNext(new LinkedListNodeImpl(20));
            A.getNext().getNext().setNext(new LinkedListNodeImpl(30));
            AlgsDSHelper.DisplayLinkedListNode(A);
            AlgsDSHelper.DisplayLinkedListNode(reverseIterative(A));
            Console.WriteLine("");
        }
        public static void printReverse(ListNode A)
        {
            ListNode current = A;
            ListNode prev = null;
            ListNode next = null;
            
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            while (prev != null)
            {

            }

        }
        public static ListNode reverseList(ListNode A)
        {
            ListNode current = A;
            ListNode prev = null;
            ListNode next = null;


            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
        public static LinkedListNode<int> reverseIterative(LinkedListNode<int> A)
        {
            LinkedListNode<int> current = A;
            LinkedListNode<int> prev = null;
            LinkedListNode<int> next = null;


            while (current != null)
            {
                next = current.getNext();
                current.setNext(prev);
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
