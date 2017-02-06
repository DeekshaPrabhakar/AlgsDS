using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class DetectCycle
    {
        public static void Run()
        {
            Console.WriteLine("Linked Lists: DetectCycle : 1->2->3");
            ListNode E = new ListNode(1);
            E.next = new ListNode(2);
            E.next.next = new ListNode(3);
            E.next.next.next = E.next;
            Console.WriteLine(hasCycle(E));
        }
        private static bool hasCycle(ListNode head)
        {
            if (head.next == null)
            {
                return false;
            }

            //2 pointers slow moves one point at a time, fast moves 2 points at a time. If slow = fast then there is a cycle
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
