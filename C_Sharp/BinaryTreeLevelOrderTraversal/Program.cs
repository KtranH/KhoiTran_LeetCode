using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]
Example 2:

Input: root = [1]
Output: [[1]]
Example 3:

Input: root = []
Output: []
*/

namespace BinaryTreeLevelOrderTraversal
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
            {
                return null;
            }
            this.val = data[0];
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            int i = 1;
            while (queue.Any() && i < data.Count)
            {
                TreeNode node = queue.Dequeue();
                if (i < data.Count && data[i] != null)
                {
                    node.left = new TreeNode(data[i]);
                    queue.Enqueue(node.left);
                }
                i++;
                if (i < data.Count && data[i] != null)
                {
                    node.right = new TreeNode(data[i]);
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return this;
        }
        public List<List<int>> solve_binary_tree_level_order_traversal()
        {
            if (this == null)
            {
                return new List<List<int>>();
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            List<List<int>> result = new List<List<int>>();
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                List<int> levelOrder = new List<int>();
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    levelOrder.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                result.Add(levelOrder);
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
            Console.WriteLine(root.solve_binary_tree_level_order_traversal());
            Console.ReadKey();
        }
    }
}
