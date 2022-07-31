using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple.Algoriths.Graph
{
    public class DisjointSetPathCompression
    {
        public int[] Root;
        public DisjointSetPathCompression(int size)
        {
            Root = new int[size];
            for (int i = 0; i < size; i++)
                Root[i] = i;
                
        }

        public int Find(int x)
        {
            if (Root[x] == x)
                return x;
            else
            {
                return Find(Root[x]);
            }
        }

        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
                Root[y] = rootX;

        }

        public Boolean IsConnected(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}
