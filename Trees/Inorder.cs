using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class Inorder
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Inorder Traversal");
            TreeNode inOrderOne = new TreeNode(1);
            inOrderOne.right = new TreeNode(2);
            inOrderOne.right.left = new TreeNode(3);
            AlgsDSHelper.DisplayList(inorderTraversal(inOrderOne));
            Console.WriteLine("");

            TreeNode inOrder = new TreeNode(314);
            inOrder.left = new TreeNode(6);
            inOrder.left.left = new TreeNode(271);
            inOrder.left.right = new TreeNode(561);
            inOrder.left.left.left = new TreeNode(28);
            inOrder.left.left.right = new TreeNode(0);

            inOrder.left.right.right = new TreeNode(3);
            inOrder.left.right.right.left = new TreeNode(17);

            inOrder.right = new TreeNode(6);
            inOrder.right.left = new TreeNode(2);
            inOrder.right.right = new TreeNode(271);
            AlgsDSHelper.DisplayList(inorderTraversal(inOrder));
            Console.WriteLine("");
            Console.WriteLine("");
        }
        private static List<int> inorderTraversal(TreeNode A)
        {
            List<int> list = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>(); //only left nodes
            Queue<TreeNode> s = new Queue<TreeNode>();
            TreeNode currentNode = A;

            while(stack.Count > 0 || currentNode != null)
            {
                if(currentNode!= null)
                {//keep going left
                    stack.Push(currentNode);
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = stack.Pop(); //last left child 
                    list.Add(currentNode.val);
                    currentNode = currentNode.right;
                }
            }

            return list;
        }
    }
}
