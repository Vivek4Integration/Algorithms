using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem.Tests
{
    [TestClass()]
    public class LongestSubstringSequenceTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            var result = LongestSubstringSequence.LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(3, result);
        }

        
    }
}