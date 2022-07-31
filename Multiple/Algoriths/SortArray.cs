using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths
{
    public class SortArray
    {
        public static int[] SortArray_HashMap(int[] numbers)
        {
            SortedDictionary<int,int> hashtable = new SortedDictionary<int,int>();
            foreach(var i in numbers)
            {
                if (hashtable.ContainsKey(i))
                    hashtable[i] = (int)hashtable[i] + 1;
                else
                {
                    hashtable[i] = 1;
                }
            }

            int[] result = new int[numbers.Length];
            int index = 0;
            foreach (var key in hashtable.Keys)
            {
                var counter = 0;
                while (hashtable[key] > counter)
                {
                    result[index] = key;
                    index++;
                    counter++;
                }
            }



            return result;
        }
    }
}
