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
    public class CostClimbingStairsTests
    {
        [TestMethod()]
        public void MinCostClimbingStairsTest1()
        {
            var result = CostClimbingStairs.MinCostClimbingStairs(new int[] { 10, 15, 20 });
            Console.Out.WriteLine(result);
            Assert.IsTrue(result==15);
        }

        [TestMethod()]
        public void MinCostClimbingStairsTest2()
        {
            var result = CostClimbingStairs.MinCostClimbingStairs(new int[] { 1,3,2,5,6,10,4 });
            Console.Out.WriteLine(result);
            Assert.IsTrue(result == 13);
        }
    }
}