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
    public class MissingRangesTests
    {
        [TestMethod()]
        public void FindMissingRangesTest()
        {
            MissingRanges.FindMissingRanges(new int[] { 0, 1, 3, 50, 75 }, 0, 99);
        }
    }
}