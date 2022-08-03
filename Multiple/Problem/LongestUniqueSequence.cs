using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public static class LongestUniqueSequence
    {
        public static int FindLongestSequence(List<int> sequence)
        {
            if (sequence.Count < 2)
                return sequence.Count;
            var result = 0;
            var a = sequence[0];
            var b = sequence[1];
            var lastNumber = b;
            var lastNumberCount = a==b?0:1;
            var length = 1;
            var max_length = 1;

            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] == a || sequence[i] == b)
                {
                    length++;
                    if (b == sequence[i])
                        lastNumberCount++;
                    else
                    {
                        lastNumber = a;
                        lastNumberCount = 1;

                    }
                }
                else
                {
                    a = lastNumber;
                    b = i;
                    lastNumber = b;
                    length = lastNumberCount + 1;
                }

                max_length = length > max_length ? length : max_length;
            }
            return max_length;
        }
    }
}
