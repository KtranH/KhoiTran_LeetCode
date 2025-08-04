using System;
using System.Collections.Generic;

/*
Example 1:


Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:


Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:


Input: p = [1,2,1], q = [1,1,2]
Output: false
*/


namespace SameTree
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
        public void insert_level_order(int?[] values)
        {
            if (values.Length == 0)
            {
                return;
            }
            int i = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            this.val = values[0];
            queue.Enqueue(this);
            while (i < values.Length)
            {
                TreeNode node = queue.Dequeue();
                if (i < values.Length && values[i] != null)
                {
                    node.left = new TreeNode(values[i].GetValueOrDefault());
                    queue.Enqueue(node.left);
                }
                i++;
                if (i < values.Length && values[i] != null)
                {
                    node.right = new TreeNode(values[i].GetValueOrDefault());
                    queue.Enqueue(node.right);
                }
                i++;
            }
        }
        public bool solve_isSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;
            if (p.val != q.val)
                return false;
            return solve_isSameTree(p.left, q.left) && solve_isSameTree(p.right, q.right);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode p = new TreeNode();
            p.insert_level_order(new int[] { 1, 2, 3 });
            TreeNode q = new TreeNode();
            q.insert_level_order(new int[] { 1, 2, null, 3 });
            Console.WriteLine(p.solve_isSameTree(p, q));
            Console.ReadKey();
        }
    }
}