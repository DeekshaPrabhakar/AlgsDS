using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class MergePoint
    {
        public static void Run()
        {

            Console.WriteLine("GetNode");
            ListNode E = new ListNode(1);
            E.next = new ListNode(2);
            E.next.next = new ListNode(3);
            //E.next.next.next = new ListNode(4);
            ListNode F = new ListNode(1);
            F.next = new ListNode(3);
            //F.next.next = new ListNode(3);
            Console.WriteLine(FindMergeNode(E, F));
        }
        private static int FindMergeNode(ListNode headA, ListNode headB)
        {
            int aCount = getCount(headA);
            int bCount = getCount(headB);

            int diff = aCount > bCount ? aCount-bCount: bCount-aCount;

            ListNode listOne = headA;
            ListNode listTwo = headB;

            if(aCount > bCount)
            {
                int index = diff;
                while(index>0)
                {
                    listOne = listOne.next;
                    index--;
                }
            }
            else
            {
                int index = diff;
                while (index > 0)
                {
                    listTwo = listTwo.next;
                    index--;
                }
            }

            while(listOne != null && listTwo != null)
            {
                if(listOne.val == listTwo.val)
                {
                    return listOne.val;
                }
                else
                {
                    listOne = listOne.next;
                    listTwo = listTwo.next;
                }
            }
            return -1;
        }

        protected static int getCount(ListNode A)
        {
            int count = 0;
            ListNode current = A;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
      
    }
}
