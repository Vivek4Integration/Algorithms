using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class EvaluateBooleanTree
    {
        public bool EvaluateTree(TreeNode root)
        {
            if (root.left == null && root.right==null)
                return root.val==0?false:true;
            if (root.val == 2)
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            if (root.val == 3)
                return EvaluateTree(root.left) && EvaluateTree(root.right);
            return false;
        }
    }
}
