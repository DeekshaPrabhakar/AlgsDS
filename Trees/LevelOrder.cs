using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class LevelOrder
    {
        public static void Run()
        {
            Console.WriteLine("Trees: Height Of Binary Tree");

            TreeNode inOrder = new TreeNode(3);
            inOrder.left = new TreeNode(5);
            inOrder.left.left = new TreeNode(1);
            inOrder.left.right = new TreeNode(4);
            //inOrder.left.left.left = new TreeNode(0);
            //inOrder.left.left.right = new TreeNode(9);

            //inOrder.left.right.right = new TreeNode(3);
            //inOrder.left.right.right.left = new TreeNode(17);

            inOrder.right = new TreeNode(2);
            inOrder.right.left = new TreeNode(6);
            //inOrder.right.right = new TreeNode(7);
            //inOrder.right.right.left = new TreeNode(8);
            AlgsDSHelper.DisplayList(LevelOrderTraversal(inOrder));
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static List<int> LevelOrderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode current = root;
            

            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                list.Add(current.val);
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }               
            }

            return list;
        }
    }
}
