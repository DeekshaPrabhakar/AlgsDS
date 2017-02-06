using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class InsertNodeSortedDoublyLL
    {
        public static void Run()
        {
            Console.WriteLine("Insert Node in Sorted Doubly Linked list");
            Node nodeOne = new Node(2);
            Node nodeTwo = new Node(5);
            nodeOne.next = nodeTwo;
            nodeTwo.prev = nodeOne;
            Node nodeThree = new Node(4);
            nodeTwo.next = nodeThree;
            nodeThree.prev = nodeTwo;

            Node output = SortedInsert(null, 2);            
            output = SortedInsert(output, 1);;
            output = SortedInsert(output, 4);
            output = SortedInsert(output, 3);
            AlgsDSHelper.DisplayDoublyLinkedList(output);


            Node outputTwo = SortedInsert(null, 1);
            outputTwo = SortedInsert(outputTwo, 4);
            outputTwo = SortedInsert(outputTwo, 2);
            outputTwo = SortedInsert(outputTwo, 3);
            outputTwo = SortedInsert(outputTwo, 7);
            outputTwo = SortedInsert(outputTwo, 6);
            outputTwo = SortedInsert(outputTwo, 9);
            outputTwo = SortedInsert(outputTwo, 10);
            AlgsDSHelper.DisplayDoublyLinkedList(outputTwo);        
        }

        private static Node SortedInsert(Node head, int data)
        {
            Node dummyHead = head;

            if(head == null)
            {
                return new Node(data);
            }

            Node current = dummyHead;
            Node prev =  null;
            while(current != null)
            {
                if(current.data >= data && current.prev == null)
                {
                    Node newNode = new Node(data);
                    newNode.next = current;
                    current.prev = newNode;
                    return newNode;
                }
                else if(current.data >= data)
                {
                    prev = current.prev;
                    Node next = current;
                    current = new Node(data);
                    prev.next = current;
                    next.prev = current;
                    current.prev = prev;
                    current.next = next;
                    return dummyHead;
                }
                prev = current;
                current = current.next;
            }

            current = new Node(data);
            prev.next = current;
            current.prev = prev;
            return head;
        }
    }
}
