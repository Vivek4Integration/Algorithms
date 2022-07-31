using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths
{
    public class Node
    {
        public Node Right { get; set; }
        public Node Left { get; set; }
        public int Value { get; set; }

    }

    public class BSTValidator
    {
       

        public Boolean ValidatorBST(Node node, int lower, int upper)
        {
            if (node == null)
                return true;
            var val = node.Value;
            if (val <= lower || val >= upper)
                return false;
            if (!ValidatorBST(node.Right, val, upper))
                return false;
            if (!ValidatorBST(node.Left, lower, val))
                return false;
            return true;
        }
    }
    
}
