using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class ClimbingStairs
    {

        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            int[] ways = new int[n + 1];
            ways[1] = 1;
            ways[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2];
            }
            return ways[n];
        }
    }
}
