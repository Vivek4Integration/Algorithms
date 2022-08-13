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
    public class LongestSubstring2CharTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTwoDistinctTest()
        {
            var result = LongestSubstring2Char.LengthOfLongestSubstringTwoDistinct("ccaabbb");
        }
    }
}