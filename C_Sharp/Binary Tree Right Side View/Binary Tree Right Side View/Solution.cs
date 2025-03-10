using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Right_Side_View
{
    public class Node
    {
        public int val { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int val)
        {
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
            {
                return null;
            }
            int i = 1;
            Queue<Node> queue = new Queue<Node>();
            this.root = new Node(values[0].GetValueOrDefault());
            queue.Enqueue(root);
            while(i < values.Length)
            {
                Node node = queue.Dequeue();
                if (i < values.Length && values[i] != null)
                {
                    node.left = new Node(values[i].GetValueOrDefault());
                    queue.Enqueue(node.left);
                }
                i++;
                if (i < values.Length && values[i] != null)
                {
                    node.right = new Node(values[i].GetValueOrDefault());
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return this.root;
        }
        public List<int> solve_binary_tree_right_side_view(Node root)
        {
            List<int> result = new List<int>();
            if(root == null)
            {
                return result;
            }    
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Node node = queue.Dequeue();
                    if (i == size - 1)
                    {
                        result.Add(node.val);
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
            return result;
        }
    }
}
