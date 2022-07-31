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
    public class BSTValidatorTests
    {
        [TestMethod()]
        public void ValidatorBSTTest_RightChildValueNotValid()
        {
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();

            node1.Left = node2;
            node1.Right = node3;
            node3.Left = node4;
            node3.Right = node5;

            node1.Value = 5;
            node2.Value = 1;
            node3.Value = 4;
            node4.Value = 3;
            node5.Value = 6;

            BSTValidator bstValidator = new BSTValidator();
            var result = bstValidator.ValidatorBST(node1,Int32.MinValue,Int32.MaxValue);
            Console.Out.WriteLine(result);
            Assert.IsFalse(result);

        }

        [TestMethod()]
        public void ValidatorBSTTest_InvalidSubTree()
        {
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();

            node1.Left = node2;
            node1.Right = node3;
            node3.Left = node4;
            node3.Right = node5;

            node1.Value = 5;
            node2.Value = 1;
            node3.Value = 6;
            node4.Value = 7;
            node5.Value = 8;

            BSTValidator bstValidator = new BSTValidator();
            var result = bstValidator.ValidatorBST(node1, Int32.MinValue, Int32.MaxValue);
            Console.Out.WriteLine(result);
            Assert.IsFalse(result);

        }

        [TestMethod()]
        public void ValidatorBSTTest_Success()
        {
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();

            node1.Left = node2;
            node1.Right = node3;
            node3.Left = node4;
            node3.Right = node5;

            node1.Value = 5;
            node2.Value = 1;
            node3.Value = 7;
            node4.Value = 6;
            node5.Value = 8;

            BSTValidator bstValidator = new BSTValidator();
            var result = bstValidator.ValidatorBST(node1, Int32.MinValue, Int32.MaxValue);
            Console.Out.WriteLine(result);
            Assert.IsTrue(result);

        }
    }
}