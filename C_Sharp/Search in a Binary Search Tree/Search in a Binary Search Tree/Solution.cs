using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_in_a_Binary_Search_Tree
{
    public class Node
    {
        public int val { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int val) {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }
    internal class Solution
    {
        public Node root = null;
        public void insert(int val)
        {
            if(this.root == null)
            {
                this.root = new Node(val);
            }    
            else
            {
                _insert_recursive(this.root, val);
            }    
        }
        public void _insert_recursive(Node node, int val)
        {
            if (node.val > val)
            {
                if (node.left == null)
                {
                    node.left = new Node(val);
                }
                else
                {
                    _insert_recursive(node.left, val);
                }
            }
            else
            {
                if (node.right == null)
                {
                    node.right = new Node(val);
                }
                else
                {
                    _insert_recursive(node.right, val);
                }
            }
        }
        public Node solve_search_in_a_search_tree(int val)
        {
            while(this.root != null && this.root.val != val)
            {
                if (this.root.val > val)
                {
                    this.root = this.root.left;
                }
                else
                {
                    this.root = this.root.right;
                }
            }    
            return this.root;
        }
    }
}
