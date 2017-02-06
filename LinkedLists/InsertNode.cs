using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class InsertNode
    {
        public static void Run()
        {
            Console.WriteLine("Linked Lists: Insert II: 1->1->2->3 should give 2->3");
            ListNode E = new ListNode(3);
            E.next = new ListNode(5);
            E.next.next = new ListNode(4);
            E.next.next.next = new ListNode(2);
            AlgsDSHelper.DisplayLinkedList(insertNth(E, 10, 1));
        }
        public static ListNode insertNth(ListNode head, int data, int position)
        {
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = head;
            ListNode current = dummyHead.next;

            if(head == null)
            {
                if (position == 0)
                {
                    return new ListNode(data);
                }
                else
                {
                    return null;
                }
            }
            int index = position - 1;
            while(index > 0)
            {
                current = current.next;
                index--;
            }

            ListNode temp = current.next;
            current.next = new ListNode(data);
            current = current.next;
            current.next = temp;
            return dummyHead.next;

        }
    }
}
