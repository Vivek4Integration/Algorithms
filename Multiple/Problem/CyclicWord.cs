using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Multiple.Problem
{
    public class CyclicWord
    {
        private Dictionary<char, List<string>> cyclDictionary = new Dictionary<char, List<string>>();
        private List<string> visited = new List<string>();
        public CyclicWord(string[] words)
        {
            foreach (var word in words)
            {
                if(!cyclDictionary.ContainsKey(word[0]))
                    cyclDictionary.Add(word[0], new List<string>());
                cyclDictionary[word[0]].Add(word);
              
            }
            
        }

        public Boolean IsCyclicWord(string currentWord, string startWord, int length)
        {
            if (length == 1)
                return currentWord.Last() == startWord[0];
            visited.Add(currentWord);
            foreach(var word in cyclDictionary[currentWord.Last()])
            {
                if (!visited.Contains(word))
                    return IsCyclicWord(word, startWord, length - 1);
            }

            visited.Remove(currentWord);
            return false;
        }
    }
}
