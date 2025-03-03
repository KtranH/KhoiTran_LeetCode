using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaf_Similar_Trees
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
            if(values.Length == 0)
                return null;
            Queue<Node> q = new Queue<Node>();
            this.root = new Node(values[0].GetValueOrDefault());
            int i = 1;
            while (i < values.Length && q.Count != 0)
            {
                Node curr = q.Dequeue();
                if (i < values.Length && values[i] != null)
                {
                    curr.left = new Node(values[i].GetValueOrDefault());
                    q.Enqueue(curr.left);
                }
                i++;
                if (i < values.Length && values[i] != null)
                {
                    curr.right = new Node(values[i].GetValueOrDefault());
                    q.Enqueue(curr.right);
                }
                i++;
            }    
            return this.root;
        }
        public List<int> DFS(Node root)
        {
            if(root == null)
                return new List<int>();
            if(root.left == null && root.right == null)
                return new List<int>() { root.val };
            return DFS(root.left).Concat(DFS(root.right)).ToList();
        }
        public bool solve_leaf_similar_trees(Node root1, Node root2)
        {
            return DFS(root1).SequenceEqual(DFS(root2));
        }
    }
}
