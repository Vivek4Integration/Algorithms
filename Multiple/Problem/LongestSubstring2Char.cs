using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class LongestSubstring2Char
    {
        public static int LengthOfLongestSubstringTwoDistinct(string s)
        {
            //var char1 = s[0];
            //char char2='0';
            //var index1 = 0;
            //int index2=-1;
            //var maxLength = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (char2 == '0' && s[i] != char1)
            //    {
            //        char2 = s[i];
            //        index2 = i;
            //    }

            //    if (s[i] != char1 && s[i] != char2 )
            //    {
            //        maxLength = Math.Max(maxLength, i - Math.Min(index2, index1));
            //        if (s[i] != char1 )
            //        {
            //            char1 = s[i];
            //            index1 = i;
            //        }
            //        if (s[i] != char2)
            //        {
            //            char2 = s[i];
            //            index2 = i;
            //        }

            //    }
            //    if(i==s.Length-1)
            //    {

            //        maxLength = Math.Max(maxLength, i - Math.Min(index2, index1)+1);
            //    }


            //}

            //return maxLength;
            int n = s.Length;
            if (n < 3) return n;
            int left = 0;
            int right = 0;
            Dictionary<char, int> hashmap = new Dictionary<char, int>();
            int max_len = 2;
            while (right < n)
            {
                hashmap[s[right]] = right++;

                if (hashmap.Count == 3)
                {
                    int del_idx = hashmap.Min(kvp => kvp.Value);
                    hashmap.Remove(s[del_idx]);
                    left = del_idx + 1;
                }

                max_len = Math.Max(max_len, right - left);
            }
            return max_len;
        }
    }
}
