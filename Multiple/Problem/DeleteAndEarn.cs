using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class DeleteAndEarn
    {
        public static int DeleteAndEarnMethod(int[] nums)
        {
            Dictionary<int, int> points = new Dictionary<int,int>();
            int maxNumber = 0;

            // Precompute how many points we gain from taking an element
            foreach (int num in nums)
            {
                if (!points.ContainsKey(num))
                    points[num] = 0;
                

                points[num] = points[num] + num;
                maxNumber = Math.Max(maxNumber, num);
            }

            // Declare our array along with base cases
            int[] maxPoints = new int[maxNumber + 1];
            if(points.ContainsKey(1))
                maxPoints[1] = points[1];
            else
            {
                points[1] = 0;
                maxPoints[1] = 0;
            }
            

            for (int num = 2; num < maxPoints.Length; num++)
            {
                if (!points.ContainsKey(num))
                    points[num] = 0;
                // Apply recurrence relation
                int gain = points[num];
                maxPoints[num] = Math.Max(maxPoints[num - 1], maxPoints[num - 2] + gain);
            }

            return maxPoints[maxNumber];

        }

        

    }
}
