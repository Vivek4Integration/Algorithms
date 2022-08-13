using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class RemoveMDigit
    {
        public static string RemoveMdigitsImplementation(string num, int k)
        {
            Stack<int> stack = new Stack<int>();

            foreach (char digit in num.ToCharArray())
            {
                while (stack.Count > 0 && k > 0 && stack.Peek() > digit)
                {
                    stack.Pop();
                    k -= 1;
                }
                stack.Push(digit);
            }

            /* remove the remaining digits from the tail. */
            for (int i = 0; i < k; ++i)
            {
                stack.Pop();
            }

            // build the final string, while removing the leading zeros.
            StringBuilder ret = new StringBuilder();
            bool leadingZero = true;
            foreach (char digit in stack.Reverse())
            {
                if (leadingZero && digit == '0') continue;
                leadingZero = false;
                ret.Append(digit);
            }

            /* return the final string  */
            if (ret.Length == 0) return "0";
            return ret.ToString();
        }
    }
}
