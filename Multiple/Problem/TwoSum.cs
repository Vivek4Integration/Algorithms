using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class TwoSum
    {
        public static int[] TwoSumImplementation(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var complimentary = target - nums[i];
                if (map.ContainsKey(complimentary))
                    return new int[] { map[complimentary], i };
                map[nums[i]] = i;
           
                
            }

            return null;
        }
    }
}
