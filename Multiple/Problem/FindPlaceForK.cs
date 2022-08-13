﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class FindPlaceForK
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int minNum = 0;
            int maxNum = nums.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return minNum;
        }
    }
}
