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
    public class LongestUniqueSequenceTests
    {
        [TestMethod()]
        public void FindLongestSequenceTest()
        {
            var sequenceArray = new List<int>() { 1, 3, 5, 3, 1, 3, 1, 5 };
            var longest2DigitSequence = LongestUniqueSequence.FindLongestSequence(sequenceArray);
            Console.Out.WriteLine(longest2DigitSequence);
            Assert.IsTrue(longest2DigitSequence == 4);
        }

        
    }
}