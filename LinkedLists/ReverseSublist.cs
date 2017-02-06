using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class ReverseSublist
    {
        public static void Run()
        {
            Console.WriteLine("Linked Lists: ReverseSublist: 1->2->3 between 2 and 3");
            ListNode E = new ListNode(1);
            E.next = new ListNode(2);
            E.next.next = new ListNode(3);
            AlgsDSHelper.DisplayLinkedList(reverseBetween(E, 2, 3));
        }
        private static ListNode reverseBetween(ListNode A, int B, int C)
        {
            if(B == C)
            {
                return A;
            }

            ListNode dummyHead = new ListNode(0);
            dummyHead.next = A;
            ListNode sublistHead = dummyHead;
            int k = 1;
            while (k++ < B)
            {
                sublistHead = sublistHead.next;
            }

            ListNode sublistIterator = sublistHead.next;
            while (B++ < C)
            {
                ListNode temp = sublistIterator.next;
                sublistIterator.next = temp.next;
                temp.next = sublistHead.next;
                sublistHead.next = temp;
            }

            return dummyHead.next;
        }
    }
}
