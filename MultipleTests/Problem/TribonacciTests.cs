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
    public class TribonacciTests
    {
        [TestMethod()]
        public void TribonacciTest()
        {
            Assert.IsTrue(Tribonacci.TribonacciSum(25)== 1389537);
        }
    }
}