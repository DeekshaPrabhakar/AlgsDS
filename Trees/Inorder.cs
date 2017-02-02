using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class Inorder
    {
        public static List<int> inorderTraversal(TreeNode A)
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
