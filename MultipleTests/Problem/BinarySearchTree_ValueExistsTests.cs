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
    public class BinarySearchTree_ValueExistsTests
    {
        [TestMethod()]
        public void ContainsTest()
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);
           Assert.IsTrue(BinarySearchTree_ValueExists.Contains(n2, 3));
        }

       
    }
}