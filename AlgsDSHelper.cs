using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS
{
    public class AlgsDSHelper
    {
        public static void DisplayDoublyLinkedList(Node list)
        {
            Node curr = list;
            while (curr != null)
            {
                if (curr.next != null)
                {
                    Console.Write(curr.data + "->");
                }
                else
                {
                    Console.Write(curr.data);
                }
                curr = curr.next;
            }
        }
        public static void DisplayLinkedList(ListNode list)
        {
            ListNode curr = list;
            while (curr != null)
            {
                if (curr.next != null)
                {
                    Console.Write(curr.val + "->");
                }
                else
                {
                    Console.Write(curr.val);
                }
                curr = curr.next;
            }
        }

        public static void DisplayLinkedListNode(LinkedListNode<int> list)
        {
            LinkedListNode<int> curr = list;
            while (curr != null)
            {
                if (curr.getNext() != null)
                {
                    Console.Write(curr.getValue() + "->");
                }
                else
                {
                    Console.Write(curr.getValue());
                }
                curr = curr.getNext();
            }
        }

        public static void DisplayJSON(List<String> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        public static void Display(List<List<int>> list)
        {
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void DisplayListofListofString(List<List<string>> list)
        {
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void DisplayList(List<int> list)
        {
            foreach (var value in list)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        public static void DisplayListElementsOnNewLine(List<Int64> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }

        public static void DisplayListOfStrings(List<string> list)
        {
            foreach (var value in list)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        public static void DisplayDictionary(Dictionary<string, int> dict)
        {
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
        }

        public static void DisplayDictionaryMultimap(Dictionary<int, List<String>> dict)
        {
            foreach (KeyValuePair<int, List<String>> pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, getListStrings(pair.Value));
            }
            Console.WriteLine();
        }

        public static string getListStrings(List<String> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            foreach (String str in list)
            {
                sb.Append("'" + str + "', ");
            }
            if (sb.ToString().Length > 3)
            {
                sb.Remove(sb.ToString().Length - 2, 2);
            }
            sb.Append("]");

            return sb.ToString();
        }

        public static void DisplayHashtable(Hashtable map)
        {
            foreach (DictionaryEntry pair in map)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
        }
    }
}
