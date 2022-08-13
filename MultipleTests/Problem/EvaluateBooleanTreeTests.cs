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
    public class EvaluateBooleanTreeTests
    {
        [TestMethod()]
        public void EvaluateTreeTest()
        {
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(0);
            
            root.right.right = new TreeNode(1);
         
            Assert.IsTrue(new EvaluateBooleanTree().EvaluateTree(root));
        }
    }
}