using System;
using System.Collections.Generic;

/*
Example 1:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 2:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 3:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 4:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]

Example 5:

Input: root = [7,3,15,null,null,9,20]
Output: [3,7,9,15,20]
*/

namespace BinarySearchTreeIterator
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public Stack<TreeNode> stack = new Stack<TreeNode>();

        public void _push_left(TreeNode node)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
        }

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public int next()
        {
            TreeNode node = stack.Pop();
            _push_left(node.right);
            return node.val;
        }

        public bool hasNext()
        {
            return stack.Count > 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 7, 3, 15, null, null, 9, 20 });
            while (root.hasNext())
            {
                Console.Write(root.next() + " ");
            }
            Console.ReadLine();
        }
    }
}
