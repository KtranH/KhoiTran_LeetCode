using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_ZigZag_Path_in_a_Binary_Tree
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
        public int max_length = 0;
        public Node insert_level_order(int?[] values)
        {
            if(values.Length == 0) { return null; }
            Queue<Node> queue = new Queue<Node>();
            this.root = new Node(values[0].Value);
            queue.Enqueue(this.root);
            int i = 1;
            while(i < values.Length && queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if(i < values.Length && values[i] != null)
                {
                    node.left = new Node(values[i].Value);
                    queue.Enqueue(node.left);
                }
                i++;
                if(i < values.Length && values[i] != null)
                {
                    node.right = new Node(values[i].Value);
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return this.root;
        }
        public void DFS(Node node, string direction, int length)
        {
            if(node == null) return;
            if(length > this.max_length) { this.max_length = length; }
            if(direction == "left")
            {
                DFS(node.left, "right", length + 1);
                DFS(node.right, "left", 1);
            }
            else
            {
                DFS(node.right, "left", length + 1);
                DFS(node.left, "right", 1);
            }
        }
        public int solve_longest_zigzag_path_in_a_binary_tree(Node root)
        {
            this.DFS(root, "left", 0);
            this.DFS(root, "right", 0);
            return this.max_length;
        }
    }
}
