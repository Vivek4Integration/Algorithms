using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class LongestSubstringSequence
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            var result = 0;
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            for (int i = 0,j=0 ;j<n; j++)
            {
                if (charMap.ContainsKey((char)s[j]))
                {
                    i = Math.Max(charMap[(char)s[j]], i);
                }

                result = Math.Max(result, j - i + 1);
                charMap[(char)s[j]] = j + 1;
            }

            return result;
        }
    }
}
