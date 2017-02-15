using AlgsDS.Arrays;
using AlgsDS.BinarySearch;
using AlgsDS.BitManipulation;
using AlgsDS.Hashing;
using AlgsDS.LinkedLists;
using AlgsDS.Recursion;
using AlgsDS.Strings;
using AlgsDS.Trees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDS
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }

    public interface LinkedListNode<T>
    {
        /* getter/setter for this node's value */
        T getValue();
        void setValue(T value);

        /* getter/setter for the subsequent node, or null if this is the last node */
        LinkedListNode<T> getNext();
        void setNext(LinkedListNode<T> next);

        /**
         * Initialize this node and all of its subsequent nodes from
         * an array of values, starting with the head value at index 0
         *
         * @param listValues - the ordered values for the whole list
         */
        void setValuesFromArray(T[] listValues);
    }

    public class LinkedListNodeImpl : LinkedListNode<int>
    {
        private int data;
        private LinkedListNode<int> next;

        public LinkedListNodeImpl()
        {
        }

        public LinkedListNodeImpl(int val)
        {
            this.data = val;
            this.next = null;
        }

        public int getValue()
        {
            return this.data;
        }

        public void setValue(int val)
        {
            this.data = val;
        }

        public LinkedListNode<int> getNext()
        {
            return this.next;
        }

        public void setNext(LinkedListNode<int> next)
        {
            this.next = next;
        }

        public void setValuesFromArray(int[] listValues)
        {
            LinkedListNode<int> dummyHead = this;
            LinkedListNode<int> current = dummyHead;


            for (int i = 0; i < listValues.Length; i++)
            {
                current.setValue(listValues[i]);
                if (current.getNext() == null)
                {
                    current.setNext(new LinkedListNodeImpl());
                }
                current = current.getNext();
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; this.left = this.right = null; }
    }

    public class ParentChildNode
    {
        public string data;
        public ParentChildNode childLeft;
        public ParentChildNode childRight;
        public ParentChildNode(string x) { this.data = x; this.childLeft = null; this.childRight = null; }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;
        public Node(int x)
        {
            this.data = x;
            this.next = null;
            this.prev = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region WeekOne

            //AddOneToNumber.Run();
            //AntiDiagonals.Run();
            //FindDuplicateInArray.Run();
            //PascalTriangleRows.Run();
            //SetMatrixZeros.Run();

            //AddBinaryStrings.Run();
            //LengthOfLastWord.Run();
            //ReverseTheString.Run();
            //PrettyJSON.Run();
            //PalindromeString.Run();

            #endregion

            #region WeekTwo

            //Fraction.Run();
            //WordCount.Run();
            //AddTwoNumbersAsLists.Run();
            //ReverseSublist.Run();
            //ReverseList.Run();
            //LinkedListImplementation.Run();
            //FindAnagrams.Run();

            //Multimaps.Run();
            //LongestSubstring.Run();
            //TwoSum.Run();
            //WindowString.Run();
            //DetectCycle.Run();
            //RemoveDuplicates.Run();
            //Palindrome.Run();
            //RemoveDuplicatesII.Run();
            //GetNode.Run();
            //MergePoint.Run();
            //ReverseDoublyLinkedList.Run();
            //InsertNodeSortedDoublyLL.Run();
            //RansomNote.Run();
            //PhoneBook.Run();

            #endregion

            #region WeekThreeBeforeSession

            //ValidBST.Run();
            //Inorder.Run();
            //SymmetricBT.Run();
            //CountOccurences.Run();
            //RangeSearch.Run();
            //SquareRoot.Run();

            //Preorder.Run();
            //PostOrder.Run();
            //RotatedArray.Run();

            //HeightOfBinaryTree.Run();
            //TreeTopView.Run();
            //LevelOrder.Run();
            //BSTInsertion.Run();

            #endregion

            //Factorial.Run();

            ///Run();
            //WeekTwo.run();
            //Subset.Run();
            //OneBits.Run();
            //SingleNumber.Run();
            //LetterPhone.Run();
            //Subset.Run();
            //AlgsDSHelper.DisplayList(Inorder.inorderTraversal(bstFromPreOrderTwo()));
            //Console.WriteLine(isValidBST(bstFromPreOrderTwo()));
            //TreeNode root = bstFromPreOrderTwo();
            //int left = getHeight(root.left);
            //int right = getHeight(root.right);
            //int diff = left > right ? left - right : right -left;
            //if(diff >=2)
            //{
            //    Console.WriteLine("Not BST");
            //}
            //else{
            //     Console.WriteLine("YES BST");
            //}

            //createBST(new int[] { 2,1,3 });
            //valisBST();
            //sExpression();

            //DecimalToBinary.Run();
            //TowersOfHanoi.Run();

            //AlgsDSHelper.Display(permute(new int[] { 1, 2, 3}));

            //Permutation.Run();
            ReverseBits.Run();

            Console.ReadLine();
        }

      



        static void sExpression()
        {
            string input = Console.ReadLine();
            string[] pairs = input.Split(' ');
            ParentChildNode root = null;
            List<string> errorCodes = new List<string>();
            foreach (string pair in pairs)
            {
                createBT(pair, root, errorCodes);
            }
            string result = string.Empty;
            result = creatExpressionFromRoot(root, ref result);
            Console.WriteLine(result);
        }

        static void createBT(string pair, ParentChildNode root, List<string> errorCodes)
        {
            string cleanPair = pair.Replace("(", "");
            cleanPair = pair.Replace(")", "");
            string[] pairNodes = cleanPair.Split(',');

            if (pairNodes.Length == 2)
            {
                if (root == null)
                {
                    root = new ParentChildNode(pairNodes[0]);
                    if (root.childLeft != null)
                    {
                        root.childLeft = new ParentChildNode(pairNodes[1]);
                    }
                    else
                    {
                        root.childRight = new ParentChildNode(pairNodes[1]);
                    }
                }
                else
                {
                    ParentChildNode current = root;
                    findParent(pairNodes[0], current);
                    if (current == null)
                    {
                        current = new ParentChildNode(pairNodes[0]);
                        if (current.childLeft != null)
                        {
                            current.childLeft = new ParentChildNode(pairNodes[1]);
                        }
                        else
                        {
                            current.childRight = new ParentChildNode(pairNodes[1]);
                        }
                    }
                    else
                    {
                        if (current.childLeft != null)
                        {
                            current.childLeft = new ParentChildNode(pairNodes[1]);
                        }
                        else
                        {
                            current.childRight = new ParentChildNode(pairNodes[1]);
                        }
                    }
                }
            }
        }
        static void findParent(string valToFind, ParentChildNode current)
        {
            if (current.data == valToFind)
            {
                return;
            }

            if (current.childLeft != null)
            {
                findParent(valToFind, current.childLeft);
            }
            if (current.childRight != null)
            {
                findParent(valToFind, current.childRight);
            }

        }


        static string creatExpressionFromRoot(ParentChildNode rootNode, ref string exp)
        {
            if (rootNode == null)
            {
                return "";
            }

            exp = "(" + rootNode.data + "(" + creatExpressionFromRoot(rootNode.childLeft, ref exp) + "))" + "(" + creatExpressionFromRoot(rootNode.childRight, ref exp) + ")))";
            return exp;
        }

        static void valisBST()
        {
            int noOfQueries = Convert.ToInt32(Console.ReadLine());
            List<string> noOfNodesList = new List<string>();
            List<string> treeList = new List<string>();

            for (int i = 0; i < noOfQueries; i++)
            {
                noOfNodesList.Add(Console.ReadLine());
                treeList.Add(Console.ReadLine());
            }

            foreach (string tree in treeList)
            {
                Console.WriteLine(isPreOrderValidBST(tree) ? "YES" : "NO");
            }
        }

        static bool isPreOrderValidBST(string tree)
        {
            bool isValid = false;
            string[] nodes = tree.Split(' ');
            var list = nodes.Select(c => int.Parse(c)).ToList();

            TreeNode root = createBSTFomPreOrder(list);
            if (isBinarySearchTree(root))
            {
                isValid = true;
            }

            return isValid;
        }

        protected static TreeNode createBSTFomPreOrder(List<int> arr)
        {
            TreeNode root = new TreeNode(arr[0]);//root first
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            for (int i = 1; i < arr.Count; i++)
            {
                TreeNode currentNode = null;

                while (stack.Count != 0 && arr[i] > stack.Peek().val)
                {
                    currentNode = stack.Pop();
                }

                if (currentNode != null)
                {//right subtree
                    currentNode.right = new TreeNode(arr[i]);
                    stack.Push(currentNode.right);
                }
                else
                {//left subtree
                    currentNode = stack.Peek();
                    currentNode.left = new TreeNode(arr[i]);
                    stack.Push(currentNode.left);
                }
            }
            return root;

        }


        static void createBST(int[] keys)
        {
            int counter = 0;
            TreeNode root = null;

            for (int i = 0; i < keys.Length; i++)
            {
                if (root != null)
                {
                    insert(root, keys[i], ref counter);
                }
                else
                {
                    root = new TreeNode(keys[i]);
                }
                Console.WriteLine(counter);
            }

        }

        public static void insert(TreeNode root, int key, ref int counter)
        {
            counter++;
            if (key < root.val)
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(key);
                }
                else
                {
                    insert(root.left, key, ref counter);
                }
            }
            else
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(key);
                }
                else
                {
                    insert(root.right, key, ref counter);
                }
            }
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

        protected static TreeNode bstFromPreOrder()
        {
            List<int> arr = new List<int>(new int[] { 10, 5, 1, 7, 40, 50, 60 });
            TreeNode root = new TreeNode(arr[0]);
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            for (int i = 1; i < arr.Count; i++)
            {
                TreeNode currentNode = null;

                while (stack.Count != 0 && arr[i] > stack.Peek().val)
                {
                    currentNode = stack.Pop();
                }

                if (currentNode != null)
                {
                    currentNode.right = new TreeNode(arr[i]);
                    stack.Push(currentNode.right);
                }
                else
                {
                    currentNode = stack.Peek();
                    currentNode.left = new TreeNode(arr[i]);
                    stack.Push(currentNode.left);
                }
            }
            return root;

        }

        private static bool isValidBST(TreeNode A)
        {
            if (isBinarySearchTree(A))
            {
                return true;
            }
            else
            {
                return false;
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

            while (stack.Count != 0)
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

        private static void Run()
        {
            List<int> list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            AlgsDSHelper.DisplayList(Inorder.inorderTraversal(buildBST(list)));
        }

        protected static TreeNode buildBST(List<int> arr)
        {
            return buildBSTNode(arr, 0, arr.Count - 1);
        }

        private static TreeNode buildBSTNode(List<int> arr, int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            int mid = (start + end) / 2;
            TreeNode root = new TreeNode(arr[mid]);

            root.left = buildBSTNode(arr, start, mid - 1);
            root.right = buildBSTNode(arr, mid + 1, end);

            return root;
        }

    }
}
