using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class BFSNode
    {
        public int key;
        public BFSNode left, right;

        public BFSNode(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class NodeBFS
    {
        public void printInorder(BFSNode node)
        {
            if (node == null)
                return;
            printInorder(node.left);
            Console.Out.WriteLine(node.key);
            printInorder(node.right);
        }
    }
}
