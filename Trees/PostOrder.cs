using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class PostOrder
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Post Order Traversal");


            TreeNode inOrder = new TreeNode(3);
            inOrder.left = new TreeNode(5);
            inOrder.left.left = new TreeNode(1);
            inOrder.left.right = new TreeNode(4);
            //inOrder.left.left.left = new TreeNode(28);
            //inOrder.left.left.right = new TreeNode(0);

            //inOrder.left.right.right = new TreeNode(3);
            //inOrder.left.right.right.left = new TreeNode(17);

            inOrder.right = new TreeNode(2);
            inOrder.right.left = new TreeNode(6);
            //inOrder.right.right = new TreeNode(271);
            AlgsDSHelper.DisplayList(postOrderTraversal(inOrder));
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private static List<int> postOrderTraversal(TreeNode A)
        {//left -> right-> root
            List<int> list = new List<int>();
            Stack<TreeNode> firstStack = new Stack<TreeNode>();
            Stack<TreeNode> secondStack = new Stack<TreeNode>(); 

            TreeNode currentNode = A;
            firstStack.Push(currentNode);

            while (firstStack.Count > 0)
            {
                currentNode = firstStack.Pop();
                secondStack.Push(currentNode);
                if(currentNode.left!= null)
                {
                    firstStack.Push(currentNode.left);
                }
                if(currentNode.right != null)
                {
                    firstStack.Push(currentNode.right);
                }
            }

            while (secondStack.Count > 0)
            {
                currentNode = secondStack.Pop();
                list.Add(currentNode.val);
            }


            return list;
        }
    }
}
