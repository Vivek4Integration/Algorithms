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
    public class TwoSumTests
    {
      

        [TestMethod()]
        public void TwoSumImplementationTest()
        {
            var result = TwoSum.TwoSumImplementation(new int[] { 2, 7, 11, 15 },9);
            Assert.IsTrue(result[0]==0&&result[1]==1);
        }
    }
}