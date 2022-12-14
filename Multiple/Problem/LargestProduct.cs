using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class LargestProduct
    {
        
            public static int MaxProduct(int[] nums)
            {
            if (nums.Length == 0) return 0;

            int max_so_far = nums[0];
            int min_so_far = nums[0];
            int result = max_so_far;

            for (int i = 1; i < nums.Length; i++)
            {
                int curr = nums[i];
                int temp_max = Math.Max(curr, Math.Max(max_so_far * curr, min_so_far * curr));
                min_so_far = Math.Min(curr, Math.Min(max_so_far * curr, min_so_far * curr));

                max_so_far = temp_max;

                result = Math.Max(max_so_far, result);
            }

            return result;
        }
        }
    
}
