using System;

/*
Example 1:

Input: inorder = [9,3,15,20,7], postorder = [9,15,7,20,3]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: inorder = [-1], postorder = [-1]
Output: [-1]
 
*/

namespace ConstructBinaryTreefromInorderandPostorderTraversal
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public TreeNode insert_level_order(int[] values)
        {
            if (values.Length == 0)
            {
                return null;
            }
            this.val = values[0];
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            int i = 1;
            while (i < values.Length && queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                if (values[i] != null)
                {
                    current.left = new TreeNode(values[i]);
                    queue.Enqueue(current.left);
                }
                i++;
                if (i < values.Length && values[i] != null)
                {
                    current.right = new TreeNode(values[i]);
                    queue.Enqueue(current.right);
                }
                i++;
            }
            return this;
        }
        public TreeNode solve_construct_binary_tree_from_inorder_and_postorder_traversal(int[] inorder, int[] postorder)
        {
            if (inorder.Length == 0 || postorder.Length == 0)
            {
                return null;
            }
            int rootValue = postorder[postorder.Length - 1];
            TreeNode root = new TreeNode(rootValue);
            int rootIndex = Array.IndexOf(inorder, rootValue);
            int[] leftInorder = Array.Copy(inorder, 0, rootIndex);
            int[] rightInorder = Array.Copy(inorder, rootIndex + 1, inorder.Length - rootIndex - 1);
            int[] leftPostorder = Array.Copy(postorder, 0, rootIndex);
            int[] rightPostorder = Array.Copy(postorder, rootIndex, postorder.Length - rootIndex - 1);
            root.left = solve_construct_binary_tree_from_inorder_and_postorder_traversal(leftInorder, leftPostorder);
            root.right = solve_construct_binary_tree_from_inorder_and_postorder_traversal(rightInorder, rightPostorder);
            return root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TreeNode root = new TreeNode();
            root.insert_level_order(new int[] { 3, 9, 20, 15, 7 });
            TreeNode result = root.solve_construct_binary_tree_from_inorder_and_postorder_traversal(new int[] { 9, 3, 15, 20, 7 }, new int[] { 9, 15, 7, 20, 3 });
            Console.WriteLine(result.val);
            Console.ReadKey();
        }
    }
}
