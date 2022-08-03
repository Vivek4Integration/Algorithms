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
    public class ClimbingStairsTests
    {
        [TestMethod()]
        public void ClimbStairsTest()
        {
            ClimbingStairs climbing = new ClimbingStairs();
            Assert.IsTrue(climbing.ClimbStairs(3)==3);
        }

        [TestMethod()]
        public void ClimbStairsTest2()
        {
            ClimbingStairs climbing = new ClimbingStairs();
            Assert.IsTrue(climbing.ClimbStairs(2) == 2);
        }
    }
}