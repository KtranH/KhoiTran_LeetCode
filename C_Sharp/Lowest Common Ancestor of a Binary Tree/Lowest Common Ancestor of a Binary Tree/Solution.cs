using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowest_Common_Ancestor_of_a_Binary_Tree
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node(int val) {
            this.val = val;
            this.left = this.right = null;
        }
    }
    internal class Solution
    {
        public Node root = null;
        public Node insert_level_order(int?[] values)
        {
            if (values.Length == 0) return null;
            this.root = new Node(values[0].GetValueOrDefault());
            var queue = new Queue<Node>();
            queue.Enqueue(this.root);
            for (int i = 1; i < values.Length; i++)
            {
                var node = queue.Dequeue();
                if (values[i] != null)
                {
                    node.left = new Node(values[i].GetValueOrDefault());
                    queue.Enqueue(node.left);
                }
                if (i + 1 < values.Length && values[i + 1] != null)
                {
                    node.right = new Node(values[i + 1].GetValueOrDefault());
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return this.root;
        }
        public Node DFS(Node root, int p, int q)
        {
            if(root == null) return null;
            if(root.val == p || root.val == q) return root;
            var left = DFS(root.left, p, q);
            var right = DFS(root.right, p, q);
            if(left == null) return right;
            if(right == null) return left;
            return root;
        }
        public Node solve_lowest_common_ancestor_of_a_binary_tree(Node root, Node p, Node q)
        {
            return DFS(root, p.val, q.val);
        }
    }
}
