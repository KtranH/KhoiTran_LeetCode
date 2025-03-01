using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Depth_of_Binary_Tree
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node(int val = 0, Node left = null, Node right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class Solution
    {
        public Node root = null;
        public Node insert_level_order(int?[] val)
        {
            if (val.Length == 0)
            {
                return null;
            }
            int i = 1;
            Queue<Node> queue = new Queue<Node>();
            this.root = new Node(val[0].GetValueOrDefault());
            queue.Enqueue(this.root);
            while(i < val.Length && queue.Count > 0)
            {
                Node current = queue.Dequeue();
                if (val[i] != null)
                {
                    current.left = new Node(val[i].GetValueOrDefault());
                    queue.Enqueue(current.left);
                }    
                i++;
                if (val[i] != null)
                {
                    current.right = new Node(val[i].GetValueOrDefault());
                    queue.Enqueue(current.right);
                }
                i++;
            }
            return this.root;
        }
        public int solve_maximum_depth_of_binary_tree(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            return 1 + Math.Max(solve_maximum_depth_of_binary_tree(node.left), solve_maximum_depth_of_binary_tree(node.right));
        }
    }
}
