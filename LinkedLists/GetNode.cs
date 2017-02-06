using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class GetNode
    {
        public static void Run()
        {
            Console.WriteLine("GetNode");
            ListNode E = new ListNode(1);
            E.next = new ListNode(3);
            E.next.next = new ListNode(5);
            E.next.next.next = new ListNode(6);
            Console.WriteLine(NodeAt(E, 2));
        }
        private static int NodeAt(ListNode head, int n)
        {
            // This is a "method-only" submission. 
            // You only need to complete this method. 

            int count = 0;
            ListNode dummy = head;
            ListNode current = head;

            while (dummy != null)
            {
                dummy = dummy.next;
                count++;
            }

            int skip = count - 1 - n;
                        
            while(skip > 0)
            {
                current = current.next;
                skip--;
            }
            return current.val;

        }
    }
}
