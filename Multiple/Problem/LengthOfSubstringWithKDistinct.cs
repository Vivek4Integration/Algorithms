using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.SqlServer.Server;

namespace Multiple.Problem
{
    public class LengthOfSubstringWithKDistinct
    {
        public static int LengthOfSubstringWithKDistinctHelper(string s, int k)
        {
            if (s.Length * k == 0) return 0;
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            int left = 0,right = 0;
            int maxLength = 1;
            while(right<s.Length)
            {
                if(!charMap.ContainsKey(s[right]))
                    charMap.Add(s[right],right);

                charMap[s[right]] = right;
                right++;
                if (charMap.Keys.Count > k)
                {
                   var  minIndex = charMap.Min(x => x.Value);
                   charMap.Remove(s[minIndex]);
                   left = minIndex + 1;
                }
                maxLength = Math.Max(maxLength, right - left);
                
            }

            return maxLength;
        }
    }
}
