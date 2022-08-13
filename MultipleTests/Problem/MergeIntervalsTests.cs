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
    public class MergeIntervalsTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            //[[1,3],[2,6],[8,10],[15,18]]
            var ret = MergeIntervals.Merge(new[]
            {
                new[] { 1, 3 },
                new[] { 2, 6 },
                new[] { 8, 10 },
                new[] { 15, 18 },

            });

        }
        
    }
}