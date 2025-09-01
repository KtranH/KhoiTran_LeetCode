using System;
using System.Collections.Generic;
using System.Linq;

/*
Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: [[3],[20,9],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
*/
namespace BinaryTreeZigzagLevelOrderTraversal
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
        public TreeNode insert_bfs_tree(List<int> data)
        {
            if (!data.Any())
                return null;
            this.val = data.First();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            data.RemoveAt(0);
            while (queue.Any())
            {
                TreeNode node = queue.Dequeue();
                if (data.Any())
                {
                    node.left = new TreeNode(data.First());
                    queue.Enqueue(node.left);
                    data.RemoveAt(0);
                }
                if (data.Any())
                {
                    node.right = new TreeNode(data.First());
                    queue.Enqueue(node.right);
                    data.RemoveAt(0);
                }
            }
            return this;
        }
        public List<List<int>> solve_binary_tree_zigzag_level_order_traversal()
        {
            if (this == null)
                return new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            List<List<int>> result = new List<List<int>>();
            bool left_to_right = true;
            while (queue.Any())
            {
                int level_size = queue.Count;
                List<int> level_order = new List<int>();
                for (int i = 0; i < level_size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (left_to_right)
                        level_order.Add(node.val);
                    else
                        level_order.Insert(0, node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                result.Add(level_order);
                left_to_right = !left_to_right;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_bfs_tree(new List<int> { 3, 9, 20, null, null, 15, 7 });
            Console.WriteLine(root.solve_binary_tree_zigzag_level_order_traversal());
            Console.ReadKey();
        }
    }
}