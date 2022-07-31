using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.Algoriths.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Graph.Tests
{
    [TestClass()]
    public class DisjointSetQuickFindTests
    {
        [TestMethod()]
        public void RootNodeTest()
        {
            DisjointSetQuickFind disjointSet = new DisjointSetQuickFind(10);
            // 1-2-5-6-7 3-8-9 4
            disjointSet.Union(1, 2);
            disjointSet.Union(2, 5);
            disjointSet.Union(5, 6);
            disjointSet.Union(6, 7);
            disjointSet.Union(3, 8);
            disjointSet.Union(8, 9);

            Assert.IsTrue(disjointSet.IsConnected(1,5));
            Assert.IsTrue(disjointSet.IsConnected(5, 7));
            Assert.IsFalse(disjointSet.IsConnected(4, 9));

        }
    }
}