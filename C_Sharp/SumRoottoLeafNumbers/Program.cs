using System;
using System.Collections.Generic;

/*
Example 1:

Input: root = [1,2,3]
Output: 25
Explanation:
The root-to-leaf paths are:
1 -> 2: 12
1 -> 3: 13
Therefore, sum = 12 + 13 = 25.

Example 2:

Input: root = [4,9,0,5,1]
Output: 1026
Explanation:
The root-to-leaf paths are:
4 -> 9 -> 5: 495
4 -> 9 -> 1: 491
4 -> 0: 40
Therefore, sum = 495 + 491 + 40 = 1026.
*/

namespace SumRoottoLeafNumbers
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
        public TreeNode insert_level_order(int[] values)
        {
            if (values == null || values.Length == 0)
                return null;
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
        public int DFS(TreeNode root, int curr_sum)
        {
            if (root == null)
                return 0;
            curr_sum = curr_sum * 10 + root.val;
            if (root.left == null && root.right == null)
                return curr_sum;
            return DFS(root.left, curr_sum) + DFS(root.right, curr_sum);
        }
        public int solve_sum_root_to_leaf(TreeNode root)
        {
            return DFS(root, 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 1, 2, 3 });
            Console.WriteLine(root.solve_sum_root_to_leaf(root));
            Console.ReadKey();
        }
    }
}