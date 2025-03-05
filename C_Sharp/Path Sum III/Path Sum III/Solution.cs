using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_Sum_III
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
            this.root = new Node(values[0].Value);
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(this.root);
            int i = 0;
            while(queue.Count > 0 && i < values.Length)
            {
                Node node = queue.Dequeue();
                if(values[i] != null)
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
        public int DFS(Node node, long currentSum, long targetSum, Dictionary<long, int> hashMap_val)
        {
            if(node == null) return 0;
            int count = 0;
            currentSum += node.val;
            long checkHashMap = currentSum - targetSum;
            if (hashMap_val.ContainsKey(checkHashMap)) {
                count = hashMap_val[checkHashMap];
            }
            if(hashMap_val.ContainsKey(currentSum)) {
                hashMap_val[currentSum] += 1;
            } else {
                hashMap_val.Add(currentSum, 1);
            }
            count += DFS(node.left, currentSum, targetSum, hashMap_val);
            count += DFS(node.right, currentSum, targetSum, hashMap_val);
            hashMap_val[currentSum] -= 1;
            return count;
        }
        public int solve_path_sum_iii(Node root, long targetSum) {
            Dictionary<long, int> hashMap_val = new Dictionary<long, int>();
            hashMap_val.Add(0, 1);
            return DFS(root, 0, targetSum, hashMap_val);
        }
    }
}
