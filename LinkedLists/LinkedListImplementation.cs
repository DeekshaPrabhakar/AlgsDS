using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class LinkedListImplementation
    {

        public static void test()
        {
            LinkedListNode<int> head = null;
            int[] listValues = new int[] { 1, 2, 3 };

            head = new LinkedListNodeImpl(); // replace with your implementation
            head.setValuesFromArray(listValues);

            Console.WriteLine(listValues[0] == head.getValue());
            Console.WriteLine(head.getNext());
            Console.WriteLine(listValues[1] == head.getNext().getValue());
            Console.WriteLine(head.getNext().getNext());
            Console.WriteLine(listValues[2] == head.getNext().getNext().getValue());
            Console.WriteLine(head.getNext().getNext().getNext());
        }
        public interface LinkedListNode<T>
        {
            /* getter/setter for this node's value */
            T getValue();
            void setValue(T value);

            /* getter/setter for the subsequent node, or null if this is the last node */
            LinkedListNode<T> getNext();
            void setNext(LinkedListNode<T> next);

            /**
             * Initialize this node and all of its subsequent nodes from
             * an array of values, starting with the head value at index 0
             *
             * @param listValues - the ordered values for the whole list
             */
            void setValuesFromArray(T[] listValues);
        }

        public class LinkedListNodeImpl : LinkedListNode<int>
        {
            private int data;
            private LinkedListNode<int> next;

            public LinkedListNodeImpl()
            {
            }

            public LinkedListNodeImpl(int val)
            {
                this.data = val;
                this.next = null;
            }

            public int getValue()
            {
                return this.data;
            }

            public void setValue(int val)
            {
                this.data = val;
            }

            public LinkedListNode<int> getNext()
            {
                return this.next;
            }

            public void setNext(LinkedListNode<int> next)
            {
                this.next = next;
            }

            public void setValuesFromArray(int[] listValues)
            {
                LinkedListNode<int> dummyHead = this;
                LinkedListNode<int> current = dummyHead;
                

                for (int i = 0; i < listValues.Length; i++)
                {
                    current.setValue(listValues[i]);
                    if (current.getNext() == null)
                    {
                        current.setNext(new LinkedListNodeImpl());
                    }
                    current = current.getNext();
                }
            }
        }
    }
}
