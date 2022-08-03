using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class Tribonacci
    {
        static int[] memo;
        public static int TribonacciSum(int n)
        {
            memo = new int[n];
            return TribonacciHelper(n);
        }

        public static int TribonacciHelper(int n)
        {
            if (n == 3)
                return 2;
            if (n == 2)
                return 1;
            if (n == 1)
                return 1;
            if (n == 0)
                return 0;
            if (memo[n - 1] == 0)
                memo[n - 1] = TribonacciHelper(n - 1) + TribonacciHelper(n - 2) + TribonacciHelper(n - 3);
            return memo[n - 1];
        }
    }
}
