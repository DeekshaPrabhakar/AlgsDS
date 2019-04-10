using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Stacks
{
    public class MaximumElement
    {
        protected static Stack<Int64> stackList = null;
        protected static List<Int64> outputArray = null;
        public static void Run()
        {
            int noOfQueries = Convert.ToInt32(Console.ReadLine());
            if (noOfQueries > 0)
            {
                stackList = new Stack<long>();
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
                        stackList.Push(Int64.Parse(inptArray[1]));
                    }
                    break;
                case 2:
                    if (stackList.Count > 0)
                    {
                        stackList.Pop();
                    }
                    break;
                case 3:
                    outputArray.Add(stackList.Max());
                    break;
                default:
                    break;
            }
        }
    }
}
