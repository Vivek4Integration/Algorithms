using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public  class DPRobHouse
    {
        public static int Rob(int[] nums)
        {

            int N = nums.Length;

            // Special handling for empty array case.
            if (N == 0)
            {
                return 0;
            }

            int[] maxRobbedAmount = new int[nums.Length + 1];

            // Base case initializations.
            maxRobbedAmount[N] = 0;
            maxRobbedAmount[N - 1] = nums[N - 1];

            // DP table calculations.
            for (int i = N - 2; i >= 0; --i)
            {

                // Same as the recursive solution.
                maxRobbedAmount[i] = Math.Max(maxRobbedAmount[i + 1], maxRobbedAmount[i + 2] + nums[i]);
            }

            return maxRobbedAmount[0];
        }
    }
}
