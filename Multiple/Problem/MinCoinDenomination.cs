using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class MinCoinDenomination
    {
        private Dictionary<int,int> memo = new Dictionary<int, int>();

        public int CoinChange(int[] coins, int amount)
        {
            if (amount < 0)
                return -1;
            if (amount == 0)
                return 0;
            if (memo.ContainsKey(amount))
                return memo[amount];
            int minDenomination = Int32.MaxValue;
            foreach(int coin in coins)
            {
                int count = CoinChange(coins, amount - coin);
                if(count==-1)
                    continue;
                minDenomination = Math.Min(minDenomination, count + 1);

            }
            if(!memo.ContainsKey(amount))
                memo.Add(amount,0);
            memo[amount] = minDenomination == Int32.MaxValue?-1:minDenomination;
            return memo[amount];

        }
    }
}
