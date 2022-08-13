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
    public class NodeBFSTests
    {
        [TestMethod()]
        public void printInorderTest()
        {
            BFSNode tree = new BFSNode(1);

            tree.left = new BFSNode(2);
            tree.right = new BFSNode(3);
            tree.left.left = new BFSNode(4);
            tree.left.right = new BFSNode(5);

            NodeBFS nodeBfs = new NodeBFS();
            nodeBfs.printInorder(tree);
        }
    }
}