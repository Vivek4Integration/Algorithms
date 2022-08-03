using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class FromLastIndex
    {

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            return RemoveNthFromEndHelper(head, n, -1, null);
        }
        public ListNode RemoveNthFromEndHelper(ListNode head, int n, int fromLastIndex, ListNode lastNode)
        {

            if (head.next == null)
            {
                fromLastIndex = 0;
            }
            if (fromLastIndex >= 0)
                fromLastIndex++;
            if (fromLastIndex == n)
            {
                lastNode.next = head.next;
            }
            if(head.next!=null)
            return RemoveNthFromEndHelper(head.next, n, fromLastIndex, head);
            else
            {
                return null;
            }
        }
    }
}

