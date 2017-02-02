using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS.Trees
{
    public class SymmetricBT
    {
        public static bool isSymmetric(TreeNode A)
        {
            return (A == null || checkSymmetric(A.left, A.right));
        }

        public static bool checkSymmetric(TreeNode subtreeLeft, TreeNode subtreeRight)
        {
            if(subtreeLeft == null && subtreeRight == null)
            {
                return true;
            }
            else if(subtreeLeft != null && subtreeRight != null)
            {
                return (subtreeLeft.val == subtreeRight.val && checkSymmetric(subtreeLeft.left, subtreeRight.right) && checkSymmetric(subtreeLeft.right, subtreeRight.left));
            }
            return false;
        }
    }
}
