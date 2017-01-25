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
}
