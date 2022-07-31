using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Graph
{
    public class DisjointSetQuickUnion
    {
        public int[] Root;

        public DisjointSetQuickUnion(int size)
        {
            Root = new int[size];
            for (int i = 0; i < size; i++)
                Root[i] = i;
            
        }

        public int Find(int x)
        {
            while (x != Root[x])
            {
                x = Root[x];
            }

            return x;
        }

        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
                Root[y] = x;
        }

        public Boolean IsConnected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}
