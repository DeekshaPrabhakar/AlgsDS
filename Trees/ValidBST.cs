using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class ValidBST
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Valid Binary Search Tree");
            TreeNode notValidBSTOne = new TreeNode(1);
            notValidBSTOne.left = new TreeNode(2);
            notValidBSTOne.right = new TreeNode(3);
            Console.WriteLine(isValidBST(notValidBSTOne));
            Console.WriteLine("");

            TreeNode validBST = new TreeNode(2);
            validBST.left = new TreeNode(1);
            validBST.right = new TreeNode(3);
            Console.WriteLine(isValidBST(validBST));
            Console.WriteLine("");

            TreeNode notValidBST = new TreeNode(3);//11 3 2 4 1 3 -1 -1 -1 -1 -1 -1 
            notValidBST.left = new TreeNode(2);
            notValidBST.left.left = new TreeNode(1);
            notValidBST.left.left.left = new TreeNode(-1);
            notValidBST.left.left.right = new TreeNode(-1);
            notValidBST.left.right = new TreeNode(3);
            notValidBST.right = new TreeNode(4);
            notValidBST.right.left = new TreeNode(-1);
            notValidBST.right.right = new TreeNode(-1);
            Console.WriteLine(isValidBST(notValidBST));
            Console.WriteLine("");
            Console.WriteLine("");

        }
        private static int isValidBST(TreeNode A)
        {
            if (isBinarySearchTree(A))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private static bool isBinarySearchTree(TreeNode A)
        {
            if (A == null)
            {
                return true;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> inorder = new List<int>();

            TreeNode node = A;
            addNodes(node, stack);

            while(stack.Count != 0)
            {
                node = stack.Pop();
                inorder.Add(node.val);
                node = node.right;
                addNodes(node, stack);
            }

            for (int i = 1; i < inorder.Count; i++)
            {
                int val = inorder[i];
                int prev = inorder[i - 1];
                if (val <= prev)
                {
                    return false;
                }
            }
            return true;            
        }

        private static void addNodes(TreeNode node, Stack<TreeNode> stack)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
        }

        private static bool isSubTreeLesser(TreeNode root, int value)
        {
            if (root == null || root.val == -1)
            {
                return true;
            }

            if (root.val <= value && isSubTreeLesser(root.left, value) && isSubTreeLesser(root.right, value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool isSubTreeGreater(TreeNode root, int value)
        {
            if (root == null || root.val == -1)
            {
                return true;
            }

            if (root.val > value && isSubTreeGreater(root.left, value) && isSubTreeGreater(root.right, value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
