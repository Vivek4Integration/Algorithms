using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    
  public class TreeNode
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
  }

    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;
            else
            {
                var right = InvertTree(root.right);
                var left = InvertTree(root.right);
                root.right = left;
                root.left = right;
               

            }

            return root;
        }

        public TreeNode InvertTree_Iterative(TreeNode root)
        {
            if (root != null)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    var currentNode = queue.Dequeue();
                    (currentNode.left, currentNode.right) = (currentNode.right, currentNode.left);
                    if(currentNode.left!=null)
                        queue.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }
            }

            return root;
        }
    }
}
