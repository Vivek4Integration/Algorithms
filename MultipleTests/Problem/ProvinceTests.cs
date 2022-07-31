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
    public class ProvinceTests
    {
        [TestMethod()]
        public void FindCircleNumTest()
        {

            Province province = new Province();
            var count = province.FindCircleNum(new int[][]
            {
                new Int32[]{1, 1, 0},new int[]{1, 1, 0},new Int32[]{0, 0, 1}
            });

            Assert.AreEqual(2, count);
        }
        [TestMethod()]
        public void FindCircleNumTest2()
        {

            Province province = new Province();
            var count = province.FindCircleNum(new int[][]
            {
                new int[]{1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                new int[]{1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[]{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[]{0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[]{0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
                new int[]{0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                new int[]{0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
                new int[]{1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                new int[]{0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0},
                new int[]{0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1},
                new int[]{0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                new int[]{0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
                new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 }
            });

            Assert.AreEqual(3, count);
        }

        [TestMethod()]
        public void FindProvince_DisjointSetQuickFindTest()
        {
            Province province = new Province();
            var count = province.FindProvince_DisjointSetQuickFind(new int[][]
            {
                new int[]{1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                new int[]{1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[]{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[]{0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[]{0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
                new int[]{0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                new int[]{0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
                new int[]{1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                new int[]{0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0},
                new int[]{0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1},
                new int[]{0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                new int[]{0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
                new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 }
            });
            Assert.AreEqual(3, count);
        }
    }
}