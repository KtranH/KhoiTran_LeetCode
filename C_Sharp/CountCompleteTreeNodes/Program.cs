using System;
using System.Collections.Generic;
/*
Example 1:

Input: root = [1,2,3,4,5,6]
Output: 6
Example 2:

Input: root = []
Output: 0
Example 3:

Input: root = [1]
Output: 1
*/

namespace CountCompleteTreeNodes
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
        public void insert_level_order(int[] data)
        {
            if (data.Length == 0)
            {
                return;
            }
            this.val = data[0];
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            int i = 1;
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (i < data.Length && data[i] != null)
                {
                    node.left = new TreeNode(data[i]);
                    queue.Enqueue(node.left);
                }
                i++;
                if (i < data.Length && data[i] != null)
                {
                    node.right = new TreeNode(data[i]);
                    queue.Enqueue(node.right);
                }
                i++;
            }
        }
        public int solve_count_complete_tree_nodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + solve_count_complete_tree_nodes(root.left) + solve_count_complete_tree_nodes(root.right);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine(root.solve_count_complete_tree_nodes(root));
            Console.ReadKey();
        }
    }
}
