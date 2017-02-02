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
        public static int isValidBST(TreeNode A)
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

        protected static bool isBinarySearchTree(TreeNode A)
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

        protected static void addNodes(TreeNode node, Stack<TreeNode> stack)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
        }

        protected static bool isSubTreeLesser(TreeNode root, int value)
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

        protected static bool isSubTreeGreater(TreeNode root, int value)
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
