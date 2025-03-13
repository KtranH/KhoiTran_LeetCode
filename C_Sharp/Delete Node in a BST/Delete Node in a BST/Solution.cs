using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Node_in_a_BST
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
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
        public void insert(int val)
        {
            if (this.root == null)
            {
                this.root = new Node(val);
            }
            else
            {
                this._insert_recursive(this.root, val);
            }
        }
        public void _insert_recursive(Node root, int val)
        {
            if(val < root.val)
            {
                if(root.left == null)
                {
                    root.left = new Node(val);
                }    
                else
                {
                    this._insert_recursive(root.left, val);
                }    
            }
            else
            {
                if(root.right == null)
                {
                    root.right = new Node(val);
                }    
                else
                {
                    this._insert_recursive(root.right, val);
                }
            }    
        }
        public int find_successor(Node root)
        {
            if(root == null)
            {
                return -1;
            }    
            while(root.left != null)
            {
                root = root.left;
            }    
            return root.val;
        }
        public Node solved_delete_node_in_a_bst(Node root, int key)
        {
            if (root == null)
            {
                return null;
            }
            if (key < root.val)
            {
                root.left = solved_delete_node_in_a_bst(root.left, key);
            }
            else if(key >  root.val)
            {
                root.right = solved_delete_node_in_a_bst(root.right, key);
            }  
            else
            {
                if(root.left == null)
                {
                    return root.right;
                }    
                else if(root.right == null)
                {
                    return root.left;
                }
                else
                {
                    int successor = find_successor(root.right);
                    root.val = successor;
                    root.right = solved_delete_node_in_a_bst(root.right, successor);
                }    
            }    
            return root;
        }
    }
}
