using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            
            intervals = intervals.OrderBy(y=>y[0]).ToArray();
            List<int[]> merged = new List<int[]>();
            foreach (int[] interval in intervals)
            {
                if (merged.Count == 0 || merged.Last()[1] < interval[0])
                    merged.Add(interval);
                else
                {
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }
            }

            return merged.ToArray();
        }

    }
}
