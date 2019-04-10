using AlgsDS.Arrays;
using AlgsDS.BinarySearch;
using AlgsDS.BitManipulation;
using AlgsDS.Hashing;
using AlgsDS.Heaps;
using AlgsDS.LinkedLists;
using AlgsDS.Recursion;
using AlgsDS.Stacks;
using AlgsDS.Strings;
using AlgsDS.Trees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

            #region WeekThree

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
            //ReverseBits.Run();
            //Fibonacci.Run();
            //MaximizingXOR.Run();
            //CounterGame.Run();
            //pascalTriangle(7);
            //int _tests_size = 0;
            //_tests_size = Convert.ToInt32(Console.ReadLine());
            //string[] _tests = new string[_tests_size];
            //string _tests_item;
            //for (int _tests_i = 0; _tests_i < _tests_size; _tests_i++)
            //{
            //    _tests_item = Console.ReadLine();
            //    _tests[_tests_i] = _tests_item;
            //}

            //counterGame(_tests);
            //Console.WriteLine(isPowerofTwo(4));
            //Console.WriteLine(largestPowerLessThan(21));
            //string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
            //TextWriter tw = new StreamWriter(@fileName, true);
            //string res;
            //int _a;
            //_a = Convert.ToInt32(Console.ReadLine());

            //int _b;
            //_b = Convert.ToInt32(Console.ReadLine());

            //int _c;
            //_c = Convert.ToInt32(Console.ReadLine());

            //int _d;
            //_d = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(isPossible(_a, _b, _c, _d));

            //long n = Convert.ToInt64(Console.ReadLine());
            //int totalX = 0;
            //long sum = 0;
            //long xorVal = 0;
            //for (int i = 0; i <= n; i++)
            //{
            //    sum = n + i;
            //    xorVal = n ^ i;
            //    if (sum == xorVal)
            //    {
            //        totalX++;
            //    }
            //}
            //Console.WriteLine(totalX);
            //QHeap.Run();
            //MaximumElement.Run();
            List<int> l = new List<int>(new int[] { 2,4 });
            //Console.WriteLine(getUmbrellas(4, l));//1

            //l = new List<int>(new int[] { 2 });
            //Console.WriteLine(getUmbrellas(1,l));//-1

            //l = new List<int>(new int[] { 3, 5 });
            //Console.WriteLine(getUmbrellas(5, l));//1
            //Console.WriteLine(getUmbrellas(6, l));//2
            //Console.WriteLine(getUmbrellas(7, l));//-1
            //l = new List<int>(new int[] {3, 2 });
            //Console.WriteLine(getUmbrellas(16, l));//4

            l = new List<int>(new int[] { 7, 3, 1 });
            Console.WriteLine(getUmbrellas(11, l));//3
            //Console.WriteLine(getUmbrellas(14, l));//2
            Console.ReadLine();
        }

        static int getUmbrellas(int n, List<int> p)
        {
            List<int> chosen = new List<int>();
            Dictionary<string, int> memos = new Dictionary<string, int>();
            p.Sort();
            int min = int.MaxValue;
            getUmbrellasHelper(n, p, chosen, ref min, memos);
            if (min == int.MaxValue)
            {
                return -1;
            }
            return min;
        }

        static int getUmbrellasHelper(int sum, List<int> sizes, List<int> chosen, ref int minimum, Dictionary<string, int> memos)
        {
            //base case
            if (sum == 0)
            {
                AlgsDSHelper.DisplayList(chosen);
                return chosen.Count;
            }
            else
            {

                for (int i = sizes.Count - 1; i >= 0; i--)
                {
                    //choose
                    int chosenEl = sizes[i];
                    chosen.Add(chosenEl);

                    //explore
                    if (sum - chosenEl >= 0 && chosen.Count < minimum) //optimization
                    {
                        string key = chosenKey(chosen);
                        if (memos.ContainsKey(key))
                        {
                            int min = memos[key];
                            minimum = Math.Min(minimum, min);
                        }
                        else
                        {
                            int min = getUmbrellasHelper(sum - chosenEl, sizes, chosen, ref minimum, memos);


                            memos.Add(key, min);

                            minimum = Math.Min(minimum, min);
                        }
                    }
                    //unchoose
                    chosen.Remove(chosenEl);
                }
                return minimum;
            }
        }


        static string chosenKey(List<int> list)
        {
            list.Sort();
            return string.Join("", list);
        }


        static string isPossible(int a, int b, int c, int d)
        {
            while(a <=c && b <= d)
            {
                if (a == c && b == d)
                {
                    return "Yes";
                }
                int tempa = a;
                int tempb = b;
                if(a<c )
                {
                    a = a + b;
                }
                if (b < d )
                {
                    b = a + b;
                }  
            }
            return "No";
        }

       
        static void counterGame(string[] tests)
        {
            foreach (string test in tests)
            {
                ulong N = 0;

                if (ulong.TryParse(test, out N) == false)
                {
                    N = 0;
                }
                if (N > 0)
                {
                    bool isLouiseplaying = true;
                    ulong counter = N;

                    while (counter != 1)
                    {
                        if (isPowerofTwo(counter))
                        {
                            counter = counter / 2;
                        }
                        else
                        {
                            counter = counter - largestPowerLessThan(counter);
                        }
                        isLouiseplaying = !isLouiseplaying;
                    }

                    if (isLouiseplaying)
                    {
                        Console.WriteLine("Richard");
                    }
                    else
                    {
                        Console.WriteLine("Louise");
                    }
                }
            }
        }
        private static bool isPowerofTwo(ulong N)
        {
            return ((N & (N - 1)) == 0);
        }

        private static ulong largestPowerLessThan(ulong N)
        {
            N = N | (N >> 1);
            N = N | (N >> 2);
            N = N | (N >> 4);
            N = N | (N >> 8);
            return (N + 1) >> 1;
        }


        static void pascalTriangle(int k)
        {            
            if(k<2 | k> 25)
            {
                return;
            }

            for (int n = 0; n < k; n++)
            {
                printRow(n);
            }            
        }

        static void printRow(int row)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<=row; i++)
            {
                sb.Append(roCol(row, i) + " ");
            }
            if(sb.ToString().Length > 2)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            Console.WriteLine(sb.ToString());
        }

        static int roCol(int nRow, int rColumn)
        {
            int colVal = FindFactorial(nRow) /(FindFactorial(rColumn)*  FindFactorial(nRow-rColumn));
            return colVal;
        }

        private static int FindFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * FindFactorial(n - 1);
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
