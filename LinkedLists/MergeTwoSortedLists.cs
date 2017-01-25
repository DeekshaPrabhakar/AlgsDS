using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class MergeTwoSortedLists
    {
        public static ListNode mergeTwoLists(ListNode A, ListNode B)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode current = dummyHead;
            ListNode p1 = A;
            ListNode p2 = B;

            while (p1 != null && p2 != null)
            {
                if (p1.val <= p2.val)
                {
                    current.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    current.next = p2;
                    p2 = p2.next;
                }
                current = current.next;
            }

            current.next = p1 != null ? p1 : p2;
            return dummyHead.next;
        }
    }

    /*
     * ***************Merge Two Sorted Lists **************
     * 
        Merge two sorted linked lists and return it as a new list.
        The new list should be made by splicing together the nodes of the first two lists, and should also be sorted.

        For example, given following linked lists :

          5 -> 8 -> 20 
          4 -> 11 -> 15

        The merged list should be :

        4 -> 5 -> 8 -> 11 -> 15 -> 20
     */
}
