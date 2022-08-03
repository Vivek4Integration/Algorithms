using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class MaximumArea
    {
        
            public static int MaximalRectangle(int[][] matrix)
            {
                if (matrix.Length == 0) return 0;
                int maxArea = 0;
                int[,] dp = new int[matrix.Length,matrix[0].Length];

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        if (matrix[i][j] == 1)
                        {

                            // compute the maximum width and update dp with it
                            dp[i,j] = j == 0 ? 1 : dp[i,j - 1] + 1;

                            int width = dp[i,j];

                            // compute the maximum area rectangle with a lower right corner at [i, j]
                            for (int k = i; k >= 0; k--)
                            {
                                width = Math.Min(width, dp[k,j]);
                                maxArea = Math.Max(maxArea, width * (i - k + 1));
                            }
                        }
                    }
                }
                return maxArea;
        }
        
    }
}
