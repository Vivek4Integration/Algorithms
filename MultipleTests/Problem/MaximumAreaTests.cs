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
    public class MaximumAreaTests
    {
        [TestMethod()]
        public void MaximalRectangleTestArea6()
        {
            //[["1","0","1","0","0"],
            //["1","0","1","1","1"],
            //["1","1","1","1","1"],
            //["1","0","0","1","0"]]
            int[][] matrix = new int[][]
            {
                new[]{1,0,1,0,0},
                new []{1,0,1,1,1},
                new []{1,1,1,1,1},
                new []{1,0,0,1,0}
            };
            var maxArea = MaximumArea.MaximalRectangle(matrix);
            Console.Out.WriteLine(maxArea);
            Assert.IsTrue(6== maxArea);
        }

        [TestMethod()]
        public void MaximalRectangleTestArea10()
        {
            //[["1","0","1","0","0"],
            //["1","0","1","1","1"],
            //["1","1","1","1","1"],
            //["1","0","0","1","0"]]
            int[][] matrix = new int[][]
            {
                new[]{1,0,1,0,0},
                new []{1,0,1,1,1},
                new []{1,1,1,1,1},
                new []{1,1,1,1,1},
            };
            var maxArea = MaximumArea.MaximalRectangle(matrix);
            Console.Out.WriteLine(maxArea);
            Assert.IsTrue(10 == maxArea);
        }
    }
}