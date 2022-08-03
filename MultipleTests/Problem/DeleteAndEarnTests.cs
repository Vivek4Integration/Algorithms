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
    public class DeleteAndEarnTests
    {
        [TestMethod()]
        public void DeleteAndEarnMethodTest()
        {
            var result = DeleteAndEarn.DeleteAndEarnMethod(new int[] { 2, 2, 3, 3, 3, 4 });
            Console.Out.WriteLine(result);
            Assert.IsTrue(result == 9);
        }
    }
}