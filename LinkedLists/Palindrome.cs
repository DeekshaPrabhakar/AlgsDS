using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class Palindrome
    {
        public static void Run()
        {
            Console.WriteLine("Linked Lists: Palindrome List: 1->2->3 between 2 and 3");
            ListNode E = new ListNode(1);
            E.next = new ListNode(2);
            E.next.next = new ListNode(3);
            E.next.next.next = new ListNode(2);
            E.next.next.next.next = new ListNode(1);
            Console.WriteLine(lPalin(E).ToString());
        }
        private static int lPalin(ListNode A)
        {
            if(A.next == null)
            {
                return 1;
            }

            int count = 0;
            ListNode current = A;
            while(current != null)
            {
                count++;
                current = current.next;
            }

            bool isEven = count % 2 == 0 ? true : false;
            int mid = isEven ? count / 2 : count/2 + 1;

            //start reversing from the mid node
            ListNode reversedListNode = new ListNode(0);
            reversedListNode.next = A;
            int i = 0;
            while (i<mid)
            {
                reversedListNode = reversedListNode.next;
                i++;
            }

            ListNode firstHalf = A;
            ListNode secondHalf = reverseList(reversedListNode);

            while(firstHalf != null && secondHalf != null)
            {
                 if(firstHalf.val != secondHalf.val)
                 {
                     return 0;
                 }
                 firstHalf = firstHalf.next;
                 secondHalf = secondHalf.next;
            }         

            return 1;
        }

        public static ListNode reverseList(ListNode A)
        {//while reversing you just remove the links and update the links to prev node
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
    }
}
