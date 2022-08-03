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
    public class FromLastIndexTests
    {
        [TestMethod()]
        public void RemoveNthFromEndTest()
        {
            //[1,2,3,4,5] 2
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);


            FromLastIndex fromLastIndex = new FromLastIndex();
            fromLastIndex.RemoveNthFromEnd(listNode, 2);
        }
    }
}