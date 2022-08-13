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
    public class RemoveMDigitTests
    {
        [TestMethod()]
        public void RemoveMdigitsImplementationTest()
        {
            var result = RemoveMDigit.RemoveMdigitsImplementation("1432219", 3);
            Console.Out.WriteLine(result);
            Assert.IsTrue(result.Equals("1219"));
        }
    }
}