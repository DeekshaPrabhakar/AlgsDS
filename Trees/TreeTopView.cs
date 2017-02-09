using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class TreeTopView
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Height Of Binary Tree");

            TreeNode inOrder = new TreeNode(3);
            inOrder.left = new TreeNode(5);
            inOrder.left.left = new TreeNode(1);
            inOrder.left.right = new TreeNode(4);
            //inOrder.left.left.left = new TreeNode(0);
            inOrder.left.left.right = new TreeNode(9);

            //inOrder.left.right.right = new TreeNode(3);
            //inOrder.left.right.right.left = new TreeNode(17);

            inOrder.right = new TreeNode(2);
            inOrder.right.left = new TreeNode(6);
            inOrder.right.right = new TreeNode(7);
            inOrder.right.right.left = new TreeNode(8);
            AlgsDSHelper.DisplayList(top_view(inOrder));
            Console.WriteLine("");
            Console.WriteLine("");
        }       

        static List<int> top_view(TreeNode root)
        {
            List<int> list = new List<int>();
            Stack<TreeNode> leftStack = new Stack<TreeNode>();
            Queue<TreeNode> rightQueue = new Queue<TreeNode>();

            TreeNode current = root;

            while (current != null)
            {
                    leftStack.Push(current);
                    current = current.left;
            }
            current = root;
            while (current != null)
            {
                rightQueue.Enqueue(current);
                    current = current.right;
            }

            while(leftStack.Count>0)
            {
                current = leftStack.Pop();
                list.Add(current.val);
            }

            while (rightQueue.Count > 0)
            {
                current = rightQueue.Dequeue();
                if (current.val != root.val)
                {
                    list.Add(current.val);
                }
            }

            return list;
        }

    }
}
