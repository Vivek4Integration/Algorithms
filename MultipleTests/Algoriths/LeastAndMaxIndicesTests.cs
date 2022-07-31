using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiple.Algoriths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Tests
{
    [TestClass()]
    public class LeastAndMaxIndicesTests
    {
        [TestMethod()]
        public void FindRangeTest()
        {
            LeastAndMaxIndices leastAndMaxIndices = new LeastAndMaxIndices();
            leastAndMaxIndices.NumberArray = new List<int>()
            {
                1,3,3,4,5,8,9,9,9,15
            };
            Console.Out.WriteLine(leastAndMaxIndices.FindRange(9,0,leastAndMaxIndices.NumberArray.Count-1,true));
            Console.Out.WriteLine(leastAndMaxIndices.FindRange(9, 0, leastAndMaxIndices.NumberArray.Count - 1, false));

        }

        [TestMethod()]
        public void FindRangeTest_Rewritten()
        {
            LeastAndMaxIndices leastAndMaxIndices = new LeastAndMaxIndices();
            leastAndMaxIndices.NumberArray = new List<int>()
            {
                1,3,3,4,5,8,9,9,9,15
            };
            Console.Out.WriteLine(leastAndMaxIndices.FindRange_Me(3, 0, leastAndMaxIndices.NumberArray.Count - 1, true));
            Console.Out.WriteLine(leastAndMaxIndices.FindRange_Me(3, 0, leastAndMaxIndices.NumberArray.Count - 1, false));

        }
    }
}