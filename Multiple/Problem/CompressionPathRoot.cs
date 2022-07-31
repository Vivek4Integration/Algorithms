using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Problem
{
    public class CompressionPathRoot
    {
        public int[] Root;
        public CompressionPathRoot(int size)
        {
            Root = new int[size];
            for (int i = 0; i < size; i++)
                Root[i] =-1;

        }

        public int Find(int[] parent,int x)
        {
            if (parent[x] == -1)
                return x;
            else
            {
                return Find(parent, parent[x]);
            }
        }

        public void Union(int[] parent, int x, int y)
        {
            int rootX = Find(parent,x);
            int rootY = Find(parent, y);
            if (rootX != rootY)
                parent[rootX] = rootY;

        }

        
    }
}
