using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Heaps
{
  

    public class MinHeapImplementation 
    {
        private List<Int64> priorityQueue;

        public MinHeapImplementation()
        {
            priorityQueue = new List<Int64>();
        }

        public int getCount()
        {
            return priorityQueue.Count;
        }
        public Int64 getMinimum()
        {
            return priorityQueue[0];
        }

        public void deleteElement(Int64 val)
        {
            priorityQueue.Remove(val);
            heapifyFromEndToStart();
        }

        public void enqueue(Int64 val)
        {
            priorityQueue.Add(val);
            heapifyFromEndToStart();
        }
        
        private void heapifyFromEndToStart()
        {
            int pos = priorityQueue.Count - 1;
            Int64 parent = getParent(pos);
           
            while(pos > 0)
            {
                //heap[i] will have children at 2i+1 & 2i-1 and parent heap at (i-1)/2
                int parentPos = (pos - 1) / 2;
                if (priorityQueue[parentPos] < priorityQueue[pos])
                {
                    swap(parentPos, pos);
                    pos = parentPos;
                }
                else
                {
                    break;
                }
            }
        }

        private Int64 getParent(int pos)
        {
            if (pos == 0)
                return 0;
            else
            {
                double parentPos = pos / 2;
                double d = Math.Floor(parentPos);
                return priorityQueue[int.Parse(d.ToString())];
            }
        }

        public void swap(int pos1, int pos2)
        {
            Int64 temp = priorityQueue[pos1];
            priorityQueue[pos1] = priorityQueue[pos2];
            priorityQueue[pos2] = temp;
        }
    }
    public class QHeap
    {

        protected static MinHeapImplementation heapArray = null;
        protected static List<Int64> outputArray = null;
        public static void Run()
        {
            int noOfQueries = Convert.ToInt32(Console.ReadLine());
            if (noOfQueries > 0)
            {
                heapArray = new MinHeapImplementation();
                outputArray = new List<Int64>();
                for (int i = 0; i < noOfQueries; i++)
                {
                    string[] inpt = Console.ReadLine().Split(' ');
                    handleInput(inpt);
                }
                AlgsDSHelper.DisplayListElementsOnNewLine(outputArray);
            }
        }

        public static void handleInput(string[] inptArray)
        {
            int operation = int.Parse(inptArray[0]);
            switch (operation)
            {
                case 1:
                    if (inptArray.Length == 2)
                    {
                        heapArray.enqueue(Int64.Parse(inptArray[1]));
                    }
                    break;
                case 2:
                    if (inptArray.Length == 2)
                    {
                        if (heapArray.getCount() > 0)
                        {
                            heapArray.deleteElement(Int64.Parse(inptArray[1]));
                        }
                    }
                    break;
                case 3:
                    outputArray.Add(heapArray.getMinimum());
                    break;
                default:
                    break;
            }            
        }
    }
}
