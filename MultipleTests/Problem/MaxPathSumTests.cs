using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem.Tests
{
    [TestClass()]
    public class MaxPathSumTests
    {
        [TestMethod()]
        public void MaxPathSumTest()
        {
            MaxPathSum maxPathSum = new MaxPathSum();
            TreeNode root = new TreeNode(-10);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.left.left = new TreeNode(30);
            root.right.left.right = new TreeNode(30);
            root.right.right = new TreeNode(7);
            root.right.right.left = new TreeNode(7);
            Console.Out.WriteLine(maxPathSum.MaxPathSumCalculate(root));
        }
    }
}