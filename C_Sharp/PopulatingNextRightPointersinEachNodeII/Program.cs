using System;
using System.Collections.Generic;

/*
Example 1:

Input: root = [1,2,3,4,5,null,7]
Output: [1,#,2,3,#,4,5,7,#]
Explanation: Given the above binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.
Example 2:

Input: root = []
Output: []
*/

namespace PopulatingNextRightPointersinEachNodeII
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode next;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null, TreeNode next = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
            this.next = next;
        }
        public TreeNode insert_level_order(int[] values)
        {
            if (values.Length == 0)
            {
                return null;
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
            return this;
        }
        public TreeNode solve_populating_next_right_pointers_in_each_node_ii(TreeNode root)
        {
            TreeNode result = root;
            while (root != null)
            {
                TreeNode dummy = new TreeNode(0);
                TreeNode tail = dummy;
                TreeNode curr = root;
                while (curr != null)
                {
                    if (curr.left != null)
                    {
                        tail.next = curr.left;
                        tail = tail.next;
                    }
                    if (curr.right != null)
                    {
                        tail.next = curr.right;
                        tail = tail.next;
                    }
                    curr = curr.next;
                }
                root = dummy.next;
            }   
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            root.solve_populating_next_right_pointers_in_each_node_ii(root);
            Console.WriteLine("Hello World!");
        }
    }
}
