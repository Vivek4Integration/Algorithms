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
    public class PathExistsTests
    {
        [TestMethod()]
        public void ValidPathTest1()
        {
            var arrayInput = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 0 }
            };
            Assert.IsTrue(PathExists.ValidPath(3, arrayInput, 0, 2));
        }

        [TestMethod()]
        public void ValidPathTest2()
        {
            var arrayInput = new int[][]
            {
                new int[] { 0, 4 },
                
            };
            Assert.IsTrue(PathExists.ValidPath(5, arrayInput, 0, 4));
        }

        [TestMethod()]
        public void ValidPathTest3()
        {
            var arrayInput = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 3, 5 },
                new int[] { 5, 4 },
                new int[] { 4, 3 }

            };
            Assert.IsFalse(PathExists.ValidPath(6, arrayInput, 0, 5));
        }
    }
}