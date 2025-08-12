using System;
using System.Collections.Generic;
using Internal;

/*
Example 1:

Input: root = [1,2,5,3,4,null,6]
Output: [1,null,2,null,3,null,4,null,5,null,6]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [0]
Output: [0]
*/

namespace FlattenBinaryTreetoLinkedList
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode prev = null;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public void insert_level_order(int[] values)
        {
            if (values.Length == 0)
            {
                return;
            }
            this.val = values[0];
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            int i = 1;
            while (i < values.Length && queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                if (values[i] != null)
                {
                    current.left = new TreeNode(values[i]);
                    queue.Enqueue(current.left);
                }
                i++;
                if (i < values.Length && values[i] != null)
                {
                    current.right = new TreeNode(values[i]);
                    queue.Enqueue(current.right);
                }
                i++;
            }
        }
        public void solve_flatten_binary_tree_to_linked_list(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            solve_flatten_binary_tree_to_linked_list(root.right);
            solve_flatten_binary_tree_to_linked_list(root.left);
            root.right = this.prev;
            root.left = null;
            this.prev = root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 1, 2, 5, 3, 4, null, 6 });
            root.solve_flatten_binary_tree_to_linked_list(root);
            Console.WriteLine(root.val);
            Console.ReadKey();
        }
    }
}
