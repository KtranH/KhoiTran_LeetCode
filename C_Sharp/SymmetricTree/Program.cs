using System;
using System.Collections.Generic;

/*
Example 1:


Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:


Input: root = [1,2,2,null,3,null,3]
Output: false
*/

namespace SymmetricTree
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
                return;
            this.val = values[0];
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            int i = 1;
            while (queue.Count > 0 && i < values.Length)
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
        public bool solve_isSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            return isMirror(root.left, root.right);
        }
        private bool isMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return true;
            if (t1 == null || t2 == null)
                return false;
            return t1.val == t2.val && isMirror(t1.left, t2.right) && isMirror(t1.right, t2.left);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 1, 2, 2, 3, 4, 4, 3 });
            Console.WriteLine(root.solve_isSymmetric(root));
            Console.ReadKey();
        }
    }
}
