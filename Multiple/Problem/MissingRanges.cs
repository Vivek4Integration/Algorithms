using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class MissingRanges
    {
        
            public static IList<string> FindMissingRanges(int[] nums, int lower, int upper)
            {
                var result = new List<string>();
                int prev = lower - 1;
                for(int i=0;i<=nums.Length;i++)
                {
                    int curr = (i<nums.Length)?nums[i]:upper+1;
                    if(prev+1<=curr-1)
                        result.Add(formatRange(prev+1,curr-1));
                    prev=curr;
                }

                return result;
            }

            private static string formatRange(int lower, int upper)
            {
                if (lower == upper)
                    return lower.ToString();
                return string.Concat(lower.ToString(), "->", upper.ToString());
            }
        
    }
}
