using System;

/*
Example 1:

Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]
Example 2:

Input: root = [2,1,3]
Output: [2,3,1]
Example 3:

Input: root = []
Output: []
*/

namespace InvertBinaryTree
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
            this.val = values[0];
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            int i = 1;
            while (queue.Count > 0 && i < values.Length)
            {
                TreeNode node = queue.Dequeue();
                node.left = new TreeNode(values[i++]);
                queue.Enqueue(node.left);
                if (i < values.Length)
                {
                    node.right = new TreeNode(values[i++]);
                    queue.Enqueue(node.right);
                }
            }   
        }
        public TreeNode solve_invertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            solve_invertTree(root.left);
            solve_invertTree(root.right);
            return root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 4, 2, 7, 1, 3, 6, 9 });
            root.solve_invertTree(root);
            Console.ReadKey();
        }
    }
}
