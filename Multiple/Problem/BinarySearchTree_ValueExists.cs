using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
    public class BinarySearchTree_ValueExists
    {
   
   
        public static bool Contains(Node root, int value)
        {
            if (root == null)
                return false;
            if (root.Value == value)
                return true;
            return value > root.Value ? Contains(root.Right, value) : Contains(root.Left, value);


        }



        public static void Main(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 3));
        }
    }
}

