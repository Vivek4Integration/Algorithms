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
    public class SortArrayTests
    {
        [TestMethod()]
        public void SortArray_HashMapTest()
        {
            int[] nums = new[] { 3, 3, 2, 1, 3, 2, 1 };
            Console.Out.Write("[ ");
            foreach (var item in SortArray.SortArray_HashMap(nums))
            {
                Console.Out.Write(item.ToString());
                Console.Out.Write(", ");

            }
            
            Console.Out.Write(" ]");

        }
    }
}