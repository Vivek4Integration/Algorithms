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
    public class LongestPalindromeTests
    {
        [TestMethod()]
        public void longestPalindromeTest()
        {
            Console.Out.WriteLine(LongestPalindrome.longestPalindrome("babad"));
        }
    }
}