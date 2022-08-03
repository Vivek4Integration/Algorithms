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
    public class LargestProductTests
    {
        [TestMethod()]
        public void MaxProductTest()
        {
            var largestProduct = LargestProduct.MaxProduct(new int[] { 2, 3, -2, 4 });
            Console.Out.WriteLine(largestProduct);
            Assert.IsTrue(largestProduct == 6);
        }

        [TestMethod()]
        public void MaxProductTest108()
        {
            
            var largestProduct = LargestProduct.MaxProduct(new int[] { -1, -2, -9, -6 });
            Console.Out.WriteLine(largestProduct);
            Assert.IsTrue(largestProduct == 108);
        }
    }
}