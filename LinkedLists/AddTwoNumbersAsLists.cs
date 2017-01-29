using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class AddTwoNumbersAsLists
    {
        public static ListNode addTwoNumbers(ListNode A, ListNode B)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode placeIterator = dummyHead;

            int carry = 0;

            while (A != null || B != null)
            {
                int sum = carry;
                if (A != null)
                {
                    sum += A.val;
                    A = A.next;
                }

                if (B != null)
                {
                    sum += B.val;
                    B = B.next;
                }

                placeIterator.next = new ListNode(sum % 10);
                carry = sum / 10;

                placeIterator = placeIterator.next;
            }

            if (carry > 0)
            {
                placeIterator.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }
    /*
     *  ************************************** Add Two Numbers as Lists *****************************************
            You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

            Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            Output: 7 -> 0 -> 8

                342 + 465 = 807

            Make sure there are no trailing zeros in the output list
            So, 7 -> 0 -> 8 -> 0 is not a valid response even though the value is still 807.

     */
}
