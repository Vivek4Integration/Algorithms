using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths
{
    public class LinkedListItem
    {
        public LinkedListItem(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public LinkedListItem NextNode { get; set; }
    }
    public class LinkedListAddition
    {
        public LinkedListItem AddTwoNumber(LinkedListItem l1, LinkedListItem l2, int carry)
        {
            var value = l1.Value + l2.Value + carry;
            var c = value / 10;
            var output = new LinkedListItem(value%10);

            if (l1.NextNode != null || l2.NextNode != null||c!=0)
            {
                if (l1.NextNode == null)
                    l1.NextNode = new LinkedListItem(0);
                if(l2.NextNode == null)
                    l2.NextNode = new LinkedListItem(0);
                if (l1.NextNode == null && l2.NextNode == null && c != 0)
                    l2.NextNode = new LinkedListItem(c);
                output.NextNode = AddTwoNumber(l1.NextNode, l2.NextNode, c);
                
            }
            return output;
        }

        public LinkedListItem AddTwoNumber_Iterative(LinkedListItem l1, LinkedListItem l2, int carry)
        {
            var a = l1;
            var b = l2;
            LinkedListItem output =  null, current = null;

            while(a!=null || b!= null||carry!=0)
            {
                var val = a.Value + b.Value + carry;
                carry = val / 10;
                if (current == null)
                    output = current = new LinkedListItem(val%10);
                else
                {
                    current.NextNode = new LinkedListItem(val % 10);
                    current = current.NextNode;
                }

                if (a.NextNode != null || b.NextNode != null||carry!=0)
                {
                    if (a.NextNode == null)
                        a.NextNode = new LinkedListItem(0);

                    if (b.NextNode == null)
                        b.NextNode = new LinkedListItem(0);
                    if (a.NextNode == null && b.NextNode == null && carry != 0)
                        b.NextNode = new LinkedListItem(carry);

                }
                a = a.NextNode;
                b = b.NextNode;
            }

            return output;
        }
    }
}
