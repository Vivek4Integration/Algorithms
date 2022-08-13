using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
   

    public class MaxPathSum
    {
        private int MaxSum = Int32.MinValue;

        public int MaxGain(TreeNode root)
        {
            if (root == null)
                return 0;
            var leftGain = Math.Max(MaxGain(root.left), 0);
            var rightGain = Math.Max(MaxGain(root.right), 0);

            int currentPathGain = root.val + leftGain + rightGain;
            MaxSum = Math.Max(MaxSum, currentPathGain);

            return root.val + Math.Max(leftGain, rightGain);
        }

        public int MaxPathSumCalculate(TreeNode root)
        {
            MaxGain(root);
            return MaxSum;

        }



    }
}
