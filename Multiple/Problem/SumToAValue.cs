using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class SumToAValue
    {
    
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                dictionary[list[i]] = i;
            }

            for (int i = 0; i < list.Count; i++)
            {
                int complement = sum - list[i];
                if (dictionary.ContainsKey(complement) && dictionary[complement] != i)
                {
                    return new Tuple<int, int>(i, dictionary[complement]);
                }
            }

            return null;
        }

      
    }
}

