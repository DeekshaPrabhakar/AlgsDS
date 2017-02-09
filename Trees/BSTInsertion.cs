using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class BSTInsertion
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Height Of Binary Tree");

            TreeNode inOrder = new TreeNode(4);
            inOrder.left = new TreeNode(2);
            inOrder.left.left = new TreeNode(1);
            inOrder.left.right = new TreeNode(3);
            //inOrder.left.left.left = new TreeNode(0);
            //inOrder.left.left.right = new TreeNode(9);

            //inOrder.left.right.right = new TreeNode(3);
            //inOrder.left.right.right.left = new TreeNode(17);

            inOrder.right = new TreeNode(7);
            //inOrder.right.left = new TreeNode(6);
            //inOrder.right.right = new TreeNode(7);
            //inOrder.right.right.left = new TreeNode(8);
            AlgsDSHelper.DisplayList(Inorder.inorderTraversal(insert(inOrder, 6)));
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static TreeNode insert(TreeNode root, int value)
        {
            TreeNode dummyHead = root;
            if(dummyHead == null)
            {
                return new TreeNode(value);
            }

            TreeNode current = dummyHead;

            if(value <= current.left.val)
            {

            }


            return dummyHead;
        }
    }
}
