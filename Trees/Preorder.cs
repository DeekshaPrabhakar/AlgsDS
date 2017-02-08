using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class Preorder
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Preorder Traversal");
            //TreeNode inOrderOne = new TreeNode(1);
            //inOrderOne.right = new TreeNode(2);
            //inOrderOne.right.left = new TreeNode(3);
            //AlgsDSHelper.DisplayList(preOrderTraversal(inOrderOne));
            //Console.WriteLine("");

            TreeNode inOrder = new TreeNode(3);
            inOrder.left = new TreeNode(5);
            inOrder.left.left = new TreeNode(1);
            inOrder.left.right = new TreeNode(4);

            inOrder.right = new TreeNode(2);
            inOrder.right.left = new TreeNode(6);
            AlgsDSHelper.DisplayList(preOrderTraversal(inOrder));
            Console.WriteLine("");
            Console.WriteLine("");
        }
        private static List<int> preOrderTraversal(TreeNode A)
        {//root -> left-> right
            List<int> list = new List<int>();       
            Stack<TreeNode> stack = new Stack<TreeNode>(); //only root nodes    
            TreeNode currentNode = A;

            while (stack.Count > 0 || currentNode != null)
            {
                if (currentNode != null)
                {//keep going left
                    stack.Push(currentNode);
                    list.Add(currentNode.val);
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = stack.Pop(); //last left child                     
                    currentNode = currentNode.right;
                }
            }
            return list;
        }
    }
}
