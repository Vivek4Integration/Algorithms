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
    public class LinkedListAdditionTests
    {
        [TestMethod()]
        public void AddTwoNumberTest()
        {
            var l1 = new LinkedListItem(2);
            l1.NextNode = new LinkedListItem(4);
            l1.NextNode.NextNode = new LinkedListItem(3);


            var l2 = new LinkedListItem(5);
            l2.NextNode = new LinkedListItem(6);
            l2.NextNode.NextNode = new LinkedListItem(4);

            var result = new LinkedListAddition().AddTwoNumber(l1, l2, 0);
            Assert.IsTrue(result.Value == 7);
            Assert.IsTrue(result.NextNode.Value == 0);
            Assert.IsTrue(result.NextNode.NextNode.Value == 8);


        }

       
            [TestMethod()]
            public void AddTwoNumberTest_UnevenNumber()
            {
                var l1 = new LinkedListItem(2);
                l1.NextNode = new LinkedListItem(4);
                l1.NextNode.NextNode = new LinkedListItem(3);
                l1.NextNode.NextNode.NextNode = new LinkedListItem(5);

                var l2 = new LinkedListItem(5);
                l2.NextNode = new LinkedListItem(6);
                l2.NextNode.NextNode = new LinkedListItem(4);

                var result = new LinkedListAddition().AddTwoNumber(l1, l2, 0);
                Assert.IsTrue(result.Value == 7);
                Assert.IsTrue(result.NextNode.Value == 0);
                Assert.IsTrue(result.NextNode.NextNode.Value == 8);
                Assert.IsTrue(result.NextNode.NextNode.NextNode.Value == 5);

            }

            [TestMethod()]
            public void AddTwoNumberTest_UnevenNumberAndIterative()
            {
                var l1 = new LinkedListItem(2);
                l1.NextNode = new LinkedListItem(4);
                l1.NextNode.NextNode = new LinkedListItem(3);
                l1.NextNode.NextNode.NextNode = new LinkedListItem(5);

                var l2 = new LinkedListItem(5);
                l2.NextNode = new LinkedListItem(6);
                l2.NextNode.NextNode = new LinkedListItem(4);

                var result = new LinkedListAddition().AddTwoNumber_Iterative(l1, l2, 0);
                Assert.IsTrue(result.Value == 7);
                Assert.IsTrue(result.NextNode.Value == 0);
                Assert.IsTrue(result.NextNode.NextNode.Value == 8);
                Assert.IsTrue(result.NextNode.NextNode.NextNode.Value == 5);

            }
    }
    }
