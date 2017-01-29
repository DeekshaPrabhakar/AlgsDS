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
       
    }
}
