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
    public class SimplifiedPathTests
    {
        [TestMethod()]
        public void SimplifyPathUnixTest()
        {
            Assert.IsTrue(SimplifiedPath.SimplifyPathUnix("/home//foo/").Equals("/home/foo"));
        }
    }
}