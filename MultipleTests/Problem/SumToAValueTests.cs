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
    public class SumToAValueTests
    {
        [TestMethod()]
        public void FindTwoSumTest()
        {
            Tuple<int, int> indices =  SumToAValue.FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Console.Out.WriteLine(indices.Item1+ " " +indices.Item2);
                Assert.IsTrue(indices.Item1 ==0);
                Assert.IsTrue(indices.Item2==3);
            }
        }
    }
}