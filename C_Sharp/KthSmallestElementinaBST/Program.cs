using System;

/*
Example 1:

Input: root = [3,1,4,null,2], k = 1
Output: 1
Example 2:

Input: root = [5,3,6,2,4,null,null,1], k = 3
Output: 3
*/

namespace KthSmallestElementinaBST
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
        public void insert_bfs_tree(int[] data)
        {
            if (data.Length == 0)
                return;
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
        public int solve_kth_smallest_element_in_a_bst(TreeNode root, int k)
        {
            if (root == null)
                return -1;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                k--;
                if (k == 0)
                    return root.val;
                root = root.right;
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_bfs_tree(new int[] { 3, 1, 4, null, 2 });
            int k = 1;
            int result = root.solve_kth_smallest_element_in_a_bst(root, k);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}