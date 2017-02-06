using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.LinkedLists
{
    public class ReverseDoublyLinkedList
    {
        public static void Run()
        {
            Console.WriteLine("Reverse Doubly Linked list");
            Node nodeOne = new Node(1);
            Node nodeTwo = new Node(2);
            nodeOne.next = nodeTwo;
            nodeTwo.prev = nodeOne;
            Node nodeThree = new Node(3);
            nodeTwo.next = nodeThree;
            nodeThree.prev = nodeTwo;
            Node nodeFour = new Node(4);
            nodeThree.next = nodeFour;
            nodeFour.prev = nodeThree;

            AlgsDSHelper.DisplayDoublyLinkedList(Reverse(nodeOne));
        }
        private static Node Reverse(Node head)
        {
            Node tail = head;

            while (tail.next != null)
            {
                tail = tail.next;
            }

            Node current = tail;
            Node prev = null;
            Node next = null;


            while (current != null)
            {
                next = current.next;
                prev = current.prev;
                current.next = prev;
                current.prev = next;
                current = prev;
            }
            
            return tail;
        }
    }
}
