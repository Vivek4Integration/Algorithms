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
    public class MedianOfTwoSortedArrayTests
    {
       

        [TestMethod()]
        public void FindMedianSortedArraysTest1()
        {
            var result = MedianOfTwoSortedArray.FindMedianSortedArrays(new int[] { }, new int[] { 1 });
        }
    }
}