
//Example 1:


//Input: root = [1, 7, 0, 7, -8, null, null]
//Output: 2
//Explanation:
//Level 1 sum = 1.
//Level 2 sum = 7 + 0 = 7.
//Level 3 sum = 7 + -8 = -1.
//So we return the level with the maximum sum which is level 2.
//Example 2:

//Input: root = [989, null, 10250, 98693, -89388, null, null, null, -32127]
//Output: 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Level_Sum_of_a_Binary_Tree
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
        public Node insert_level_order(int?[] values)
        {
            if(values.Length == 0) return null;
            Node root = new Node(values[0].Value);
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            int i = 1;
            while (i < values.Length)
            {
                Node node = queue.Dequeue();
                if (values[i] != null)
                {
                    node.left = new Node(values[i].Value);
                    queue.Enqueue(node.left);
                }
                i++;
                if (i < values.Length && values[i] != null)
                {
                    node.right = new Node(values[i].Value);
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return this.root;
        }
        public int solve_maximum_level_sum(Node root)
        {
            if(root == null) return 0;
            int max_level_tree = 0;
            int level_tree = 0;
            Double max_values = Double.NegativeInfinity;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                level_tree++;
                int count = queue.Count;
                Double level_sum = 0;
                while (count > 0)
                {
                    Node node = queue.Dequeue();
                    level_sum += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                    count--;
                }
                if (level_sum > max_values)
                {
                    max_values = level_sum;
                    max_level_tree = level_tree;
                }
            }
            return max_level_tree;
        }
    }
}
