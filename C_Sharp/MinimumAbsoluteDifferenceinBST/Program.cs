using System;

/*
Example 1:

Input: root = [4,2,6,1,3]
Output: 1
Example 2:

Input: root = [1,0,48,null,null,12,49]
Output: 1
*/

namespace MinimumAbsoluteDifferenceinBST
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
            if (data.Count == 0)
            {
                return null;
            }
            this.val = data[0];
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            int i = 1;
            while (queue.Count > 0)
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
        public int solve_minimum_absolute_difference_in_bst(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode prev = null;
            int result = int.MaxValue;
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (prev != null)
                {
                    result = Math.Min(result, root.val - prev.val);
                }
                prev = root;
                root = root.right;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_bfs_tree(new List<int> { 4, 2, 6, 1, 3 });
            Console.WriteLine(root.solve_minimum_absolute_difference_in_bst());
            Console.ReadKey();
        }
    }
}
