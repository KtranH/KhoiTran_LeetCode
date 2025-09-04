using System;
using System.Collections.Generic;

/*
Example 1:

Input: root = [2,1,3]
Output: true
Example 2:

Input: root = [5,1,4,null,3,6]
Output: false
*/

namespace ValidateBinarySearchTree
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public bool ValidateBinarySearchTree(TreeNode root)
        {
            if(root == null) return false;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode prev = null;
            while(root != null || stack.Count > 0)
            {
                while(root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if(prev != null && root.val <= prev.val) return false;
                prev = root;
                root = root.right;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}