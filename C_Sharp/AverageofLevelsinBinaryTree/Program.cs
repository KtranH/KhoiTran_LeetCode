using System;
using System.Collections.Generic;

/*
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
Example 2:

Input: root = [3,9,20,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].
*/

namespace AverageofLevelsinBinaryTree
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
        public void insert_level_order(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                return;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            int i = 0;
            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                if (i < values.Length)
                {
                    current.left = new TreeNode(values[i++]);
                    queue.Enqueue(current.left);
                }
                if (i < values.Length)
                {
                    current.right = new TreeNode(values[i++]);
                    queue.Enqueue(current.right);
                }
            }   
        }
        public List<double> solve_average_of_levels_in_binary_tree()
        {
            if (this == null)
            {
                return new List<double>();
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            List<double> result = new List<double>();
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                double levelSum = 0;
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    levelSum += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                result.Add(levelSum / levelSize);
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 3, 9, 20, null, null, 15, 7 });
            Console.WriteLine(root.solve_average_of_levels_in_binary_tree());
            Console.ReadKey();
        }
    }
}
