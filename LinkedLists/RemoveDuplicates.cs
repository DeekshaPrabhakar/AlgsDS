using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class RemoveDuplicates
    {
        public static void Run()
        {
            Console.WriteLine("Linked Lists: RemoveDuplicates I: 1->2->3 between 2 and 3");
            ListNode E = new ListNode(1);
            E.next = new ListNode(1);
            E.next.next = new ListNode(1);
            E.next.next.next = new ListNode(2);
            AlgsDSHelper.DisplayLinkedList(deleteDuplicates(E));
        }
        private static ListNode deleteDuplicates(ListNode a)
        {
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = a;
            ListNode current = dummyHead.next;

            while(current != null)
            {
                if (current.next != null && current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return dummyHead.next;
        }
    }
}
