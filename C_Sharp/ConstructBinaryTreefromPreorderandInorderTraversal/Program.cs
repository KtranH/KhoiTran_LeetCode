using System;
using System.Collections.Generic;

/*
Example 1:

Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
Output: [3,9,20,null,null,15,7]
Example 2:

Input: preorder = [-1], inorder = [-1]
Output: [-1]

*/
namespace ConstructBinaryTreefromPreorderandInorderTraversal
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
        public TreeNode InsertLevelOrder(int[] values)
        {
            if (values.Length == 0)
                return null;
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
        public TreeNode ConstructBinaryTreeFromPreorderAndInorderTraversal(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0 || inorder.Length == 0)
                return null;
            int rootVal = preorder[0];
            TreeNode root = new TreeNode(rootVal);
            int rootIndex = Array.IndexOf(inorder, rootVal);
            int[] leftInorder = Array.Copy(inorder, 0, rootIndex);
            int[] rightInorder = Array.Copy(inorder, rootIndex + 1, inorder.Length - rootIndex - 1);
            int[] leftPreorder = Array.Copy(preorder, 1, rootIndex);
            int[] rightPreorder = Array.Copy(preorder, rootIndex + 1, preorder.Length - rootIndex - 1);
            root.left = ConstructBinaryTreeFromPreorderAndInorderTraversal(leftPreorder, leftInorder);
            root.right = ConstructBinaryTreeFromPreorderAndInorderTraversal(rightPreorder, rightInorder);
            return root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode().InsertLevelOrder(new int[] { 3, 9, 20, 15, 7 });
            Console.WriteLine(root.ConstructBinaryTreeFromPreorderAndInorderTraversal(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 }));
            Console.ReadKey();
        }
    }
}
