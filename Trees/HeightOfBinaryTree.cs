using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class HeightOfBinaryTree
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Height Of Binary Tree");

            TreeNode inOrder = new TreeNode(3);
            inOrder.left = new TreeNode(2);
            inOrder.left.left = new TreeNode(1);
            //inOrder.left.right = new TreeNode(4);
            //inOrder.left.left.left = new TreeNode(28);
            //inOrder.left.left.right = new TreeNode(0);

            //inOrder.left.right.right = new TreeNode(3);
            //inOrder.left.right.right.left = new TreeNode(17);

            inOrder.right = new TreeNode(5);
            inOrder.right.left = new TreeNode(4);
            inOrder.right.right = new TreeNode(6);
            inOrder.right.right.right = new TreeNode(7);
            Console.WriteLine(getHeight(inOrder));
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static int getHeight(TreeNode root)
        {
            // Write your code here
            if (root == null)
            {
                return -1;
            }

            int leftHeight = getHeight(root.left);
            int rightHeight = getHeight(root.right);

            if (leftHeight >= rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
            }
        }
    }
}
