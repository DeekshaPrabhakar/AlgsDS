using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class ReverseList
    {
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
