using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Count_Good_Nodes_in_Binary_Tree
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node(int val) {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }
    internal class Solution
    {
        public Node root = null;
        public Node insert_level_order(int?[] values)
        {
            if(values.Length == 0)
                return null;
            Queue<Node> nodes = new Queue<Node>();
            this.root = new Node(values[0].Value);
            nodes.Enqueue(this.root);
            int i = 1;
            while(nodes.Count > 0 && i < values.Length)
            {
                Node current = nodes.Dequeue();
                if (values[i].HasValue)
                {
                    current.left = new Node(values[i].Value);
                    nodes.Enqueue(current.left);
                }
                i++;
                if(i < values.Length && values[i].HasValue)
                {
                    current.right = new Node(values[i].Value);
                    nodes.Enqueue(current.right);
                }
                i++;
            }
            return this.root;
        }
        public int DFS(Node root, int max_val)
        {
            int count = 0;
            if(root == null)
                return 0;
            if (root.val >= max_val)
            {
                count = 1;
                max_val = root.val;
            }
            return count + DFS(root.left, max_val) + DFS(root.right, max_val); 
        }
        public int solve_count_good_nodes_in_binary_tree(Node root)
        {
            return DFS(root, root.val);
        }
    }
}
