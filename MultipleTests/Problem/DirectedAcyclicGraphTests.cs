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
    public class DirectedAcyclicGraphTests
    {
        [TestMethod()]
        public void AllPathsSourceTargetTest()
        {
            var result = DirectedAcyclicGraph.AllPathsSourceTarget(new[]
            {
                new int[]{1,2},
                new int[]{3},
                new int[]{3},
                new int[]{}
            });
            foreach (var item in result)
            {
                foreach (var item2 in item)
                {
                    Console.Out.Write(item2);
                    Console.Out.Write(" ");
                }

                Console.Out.WriteLine();
                
            }
        }
    }
}