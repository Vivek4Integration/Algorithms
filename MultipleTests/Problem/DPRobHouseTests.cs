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
    public class DPRobHouseTests
    {
        [TestMethod()]
        public void RobTest()
        {
            var result = DPRobHouse.Rob(new int[] { 2, 7, 9, 3, 1 });
            Assert.IsTrue(result== 12);

        }
    }
}