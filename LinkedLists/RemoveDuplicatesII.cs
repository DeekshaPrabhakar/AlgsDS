using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class RemoveDuplicatesII
    {
        public static void Run()
        {
            Console.WriteLine("Linked Lists: RemoveDuplicates II: 1->1->2->3 should give 2->3");
            ListNode E = new ListNode(1);
            E.next = new ListNode(1);
            E.next.next = new ListNode(1);
            E.next.next.next = new ListNode(2);
            E.next.next.next.next = new ListNode(3);
            AlgsDSHelper.DisplayLinkedList(deleteDuplicates(E));
        }
        private static ListNode deleteDuplicates(ListNode A)
        {
            if (A.next == null)
            {
                return A;
            }

            if (A == null)
            {
                return null;
            }

            ListNode dummyHead = new ListNode(0);
            dummyHead.next = A;
            ListNode current = dummyHead; 

            while (current.next != null && current.next.next != null)
            {
                if (current.next.val == current.next.next.val)
                {
                    int duplicateVal = current.next.val;
                    while (current.next != null && current.next.val == duplicateVal)
                    {
                        current.next = current.next.next;
                    }
                }
                else
                {
                    current = current.next;
                }               
            }

            if (dummyHead.next != null)
            {
                return dummyHead.next;
            }
            else
            {
                return null;
            }
        }
    }
}
