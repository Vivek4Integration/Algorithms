using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths
{
    public class RansomNote
    {
        private Hashtable hashTable = new Hashtable();
        public Boolean CanConstruct(string subString, string allString)
        {
            foreach (var item in allString)
            {
                if (hashTable.Contains(item))
                    hashTable[item] = (Int32)hashTable[item] + 1;
                else
                {
                    hashTable[item] = 1;
                }
            }

            foreach (var item in subString)
            {
                if (hashTable[item] == null)
                    return false;
                else
                {
                    hashTable[item] = (int)hashTable[item] - 1;
                    if ((int)hashTable[item] == -1)
                        return false;
                }



            }

            return true;
        }
    }

    public class RansomNote_With_Dictionary
    {
        private Dictionary<char,int> charCounter = new Dictionary<char, int>();
        public Boolean CanConstruct(string subString, string allString)
        {
            foreach (var item in allString)
            {
                if (charCounter.ContainsKey(item))
                    charCounter[item] = charCounter[item] + 1;
                else
                {
                    charCounter[item] = 1;
                }
            }

            foreach (var item in subString)
            {
                if (!charCounter.ContainsKey(item) )
                    return false;
                else
                {
                    charCounter[item] = charCounter[item] - 1;
                    if (charCounter[item] == -1)
                        return false;
                }



            }

            return true;
        }
    }
}
